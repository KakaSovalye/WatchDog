using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

using AForge;
using AForge.Imaging.Filters;
using AForge.Imaging;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Vision.Motion;
using AForge.Math.Geometry;

namespace WatchDog
{
    public partial class Form1 : Form
    {

        private FilterInfoCollection VideoCapTureDevices;
        private VideoCaptureDevice Finalvideo;
        private bool boolHareket = false;
        private DateTime baslangic;
        private MotionDetector detector;

        public Form1()
        {
            InitializeComponent();
            txtMachine.Text = Environment.MachineName;
            txtFolder.Text = Properties.Settings.Default.Klasor;
            
        }

        private void btStartStop_Click(object sender, EventArgs e)
        {
            if (txtMachine.Text == "" || txtFolder.Text == "")
                return;
            if (btStartStop.Text == "Başlat")
            {
                baslangic = DateTime.Now;
                btStartStop.Text = "Durdur";
                detector = GetDefaultMotionDetector();
                Finalvideo = new VideoCaptureDevice(VideoCapTureDevices[cmbKameralar.SelectedIndex].MonikerString);
                Finalvideo.NewFrame += new NewFrameEventHandler(Finalvideo_NewFrame);
                Finalvideo.DesiredFrameRate = 10;//saniyede kaç görüntü alsın istiyorsanız. FPS
                Finalvideo.DesiredFrameSize = new Size(320, 240);//görüntü boyutları
                Finalvideo.Start();
                timer1.Start();
                tmrSipsak.Start();
                trackBar1.Enabled = false;
                nudHassas.Enabled = false;

            }
            else
            {
                btStartStop.Text = "Başlat";
                lblStat.Text = "WatchDog durduruldu.";
                if (Finalvideo.IsRunning)
                {
                    Finalvideo.Stop();
                }
                timer1.Stop();
                tmrSipsak.Stop();
                pbTracker.Image = null;
                trackBar1.Enabled = true;
                nudHassas.Enabled = true;
            }

        }

        public AForge.Vision.Motion.MotionDetector GetDefaultMotionDetector()
        {
            AForge.Vision.Motion.IMotionDetector mdetector = null;
            AForge.Vision.Motion.IMotionProcessing processor = null;
            AForge.Vision.Motion.MotionDetector motionDetector = null;

            mdetector = new AForge.Vision.Motion.TwoFramesDifferenceDetector()
            {
                DifferenceThreshold = trackBar1.Value,
                SuppressNoise = true
            };
                       

            processor = new AForge.Vision.Motion.BlobCountingObjectsProcessing()
            {
                HighlightColor = System.Drawing.Color.Red,
                HighlightMotionRegions = true,
                MinObjectsHeight = 10,
                MinObjectsWidth = 10
            };

            motionDetector = new AForge.Vision.Motion.MotionDetector(mdetector, processor);

            return (motionDetector);
        }

        private void Finalvideo_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {

            Bitmap image = (Bitmap)eventArgs.Frame.Clone();
            Bitmap image1 = (Bitmap)eventArgs.Frame.Clone();
            pbTracker.Image = image;
            
            if (detector.ProcessFrame((Bitmap)eventArgs.Frame.Clone()) > 0.02)
            {
                boolHareket = true;
               
            }
            else
            {
                boolHareket = false;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VideoCapTureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo VideoCaptureDevice in VideoCapTureDevices)
            {

                cmbKameralar.Items.Add(VideoCaptureDevice.Name);

            }
            if (cmbKameralar.Items.Count>0)
                cmbKameralar.SelectedIndex = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (boolHareket)
            {
                label1.Text = "Hareket Var!";
                label1.ForeColor = Color.Red;
            }
            else
            {
                label1.Text = "Temiz";
                label1.ForeColor = Color.Black;
            }
        }

        private void tmrSipsak_Tick(object sender, EventArgs e)
        {
            DateTime cekimTarihi = DateTime.Now;
            if (cekimTarihi.Subtract(baslangic).Seconds < 20)
            {
                int sure = (20 - cekimTarihi.Subtract(baslangic).Seconds);
                lblStat.Text = "WatchDog " + sure + " sn sonra devrede.";
                return;
            }
            else
            {
                lblStat.Text = "WatchDog devrede";
            }

            if (boolHareket)
            {
                
                
                pbCapture.Image = (Bitmap)pbTracker.Image.Clone();
                if (chkLokal.Checked)
                {
                    Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory+"\\"+txtMachine.Text + " - " + cekimTarihi.Year + "-" + cekimTarihi.Month + "-" + cekimTarihi.Day);
                    string lokalfilename = "cap_" + cekimTarihi.Hour + "-" + cekimTarihi.Minute + "-" + cekimTarihi.Second + ".jpg";

                    lokalfilename = AppDomain.CurrentDomain.BaseDirectory + "\\" + txtMachine.Text + " - " + cekimTarihi.Year + "-" + cekimTarihi.Month + "-" + cekimTarihi.Day + "\\" + lokalfilename;
                    pbCapture.Image.Save(lokalfilename, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                Directory.CreateDirectory(txtFolder.Text + "\\" + txtMachine.Text + " - " + cekimTarihi.Year + "-" + cekimTarihi.Month + "-" + cekimTarihi.Day);


                string filename = "cap_" + cekimTarihi.Hour + "-" + cekimTarihi.Minute + "-" + cekimTarihi.Second + ".jpg"; //"cap_" + DateTime.Now.ToLongDateString() + ".jpg";
                filename = txtFolder.Text + "\\" + txtMachine.Text + " - " + cekimTarihi.Year + "-" + cekimTarihi.Month + "-" + cekimTarihi.Day + "\\" + filename;
                pbCapture.Image.Save(filename, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }

        private void btnGozat_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                txtFolder.Text = folderBrowserDialog1.SelectedPath;
            }
            else
            {
                txtFolder.Text = @"E:\Dropbox\Security";
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            nudHassas.Value = trackBar1.Value;
        }
        
        private void nudHassas_ValueChanged(object sender, EventArgs e)
        {
            trackBar1.Value = Convert.ToInt32(nudHassas.Value);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Klasor = txtFolder.Text;
            Properties.Settings.Default.Save();
        }
    }
}
