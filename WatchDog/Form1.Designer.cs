namespace WatchDog
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbTracker = new System.Windows.Forms.PictureBox();
            this.cmbKameralar = new System.Windows.Forms.ComboBox();
            this.btStartStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tmrSipsak = new System.Windows.Forms.Timer(this.components);
            this.pbCapture = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtMachine = new System.Windows.Forms.TextBox();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGozat = new System.Windows.Forms.Button();
            this.lblStat = new System.Windows.Forms.Label();
            this.chkLokal = new System.Windows.Forms.CheckBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.nudHassas = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbTracker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCapture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHassas)).BeginInit();
            this.SuspendLayout();
            // 
            // pbTracker
            // 
            this.pbTracker.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbTracker.Location = new System.Drawing.Point(12, 70);
            this.pbTracker.Name = "pbTracker";
            this.pbTracker.Size = new System.Drawing.Size(320, 240);
            this.pbTracker.TabIndex = 0;
            this.pbTracker.TabStop = false;
            // 
            // cmbKameralar
            // 
            this.cmbKameralar.FormattingEnabled = true;
            this.cmbKameralar.Location = new System.Drawing.Point(12, 328);
            this.cmbKameralar.Name = "cmbKameralar";
            this.cmbKameralar.Size = new System.Drawing.Size(320, 21);
            this.cmbKameralar.TabIndex = 1;
            // 
            // btStartStop
            // 
            this.btStartStop.Location = new System.Drawing.Point(350, 326);
            this.btStartStop.Name = "btStartStop";
            this.btStartStop.Size = new System.Drawing.Size(75, 23);
            this.btStartStop.TabIndex = 2;
            this.btStartStop.Text = "Başlat";
            this.btStartStop.UseVisualStyleBackColor = true;
            this.btStartStop.Click += new System.EventHandler(this.btStartStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(308, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Temiz";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tmrSipsak
            // 
            this.tmrSipsak.Interval = 50;
            this.tmrSipsak.Tick += new System.EventHandler(this.tmrSipsak_Tick);
            // 
            // pbCapture
            // 
            this.pbCapture.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbCapture.Location = new System.Drawing.Point(352, 70);
            this.pbCapture.Name = "pbCapture";
            this.pbCapture.Size = new System.Drawing.Size(320, 240);
            this.pbCapture.TabIndex = 4;
            this.pbCapture.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Canlı Kamera";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "En son yakalanan görüntü";
            // 
            // txtMachine
            // 
            this.txtMachine.Location = new System.Drawing.Point(78, 355);
            this.txtMachine.Name = "txtMachine";
            this.txtMachine.Size = new System.Drawing.Size(254, 20);
            this.txtMachine.TabIndex = 7;
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(78, 381);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(254, 20);
            this.txtFolder.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Makine Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Klasör";
            // 
            // btnGozat
            // 
            this.btnGozat.Location = new System.Drawing.Point(257, 407);
            this.btnGozat.Name = "btnGozat";
            this.btnGozat.Size = new System.Drawing.Size(75, 23);
            this.btnGozat.TabIndex = 11;
            this.btnGozat.Text = "Gözat...";
            this.btnGozat.UseVisualStyleBackColor = true;
            this.btnGozat.Click += new System.EventHandler(this.btnGozat_Click);
            // 
            // lblStat
            // 
            this.lblStat.AutoSize = true;
            this.lblStat.Location = new System.Drawing.Point(440, 331);
            this.lblStat.Name = "lblStat";
            this.lblStat.Size = new System.Drawing.Size(10, 13);
            this.lblStat.TabIndex = 12;
            this.lblStat.Text = " ";
            // 
            // chkLokal
            // 
            this.chkLokal.AutoSize = true;
            this.chkLokal.Location = new System.Drawing.Point(352, 356);
            this.chkLokal.Name = "chkLokal";
            this.chkLokal.Size = new System.Drawing.Size(139, 17);
            this.chkLokal.TabIndex = 13;
            this.chkLokal.Text = "Lokalde kopyasını sakla";
            this.chkLokal.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(344, 407);
            this.trackBar1.Maximum = 50;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(286, 45);
            this.trackBar1.TabIndex = 14;
            this.trackBar1.Value = 3;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(349, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Kamera Hassasiyeti Max:50 ";
            // 
            // nudHassas
            // 
            this.nudHassas.Location = new System.Drawing.Point(633, 414);
            this.nudHassas.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudHassas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHassas.Name = "nudHassas";
            this.nudHassas.Size = new System.Drawing.Size(41, 20);
            this.nudHassas.TabIndex = 17;
            this.nudHassas.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudHassas.ValueChanged += new System.EventHandler(this.nudHassas_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(349, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(310, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "50\'nin üstünde kameraya yakalnmak için horon tepmek lazım. (o:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 448);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nudHassas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.chkLokal);
            this.Controls.Add(this.lblStat);
            this.Controls.Add(this.btnGozat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.txtMachine);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbCapture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btStartStop);
            this.Controls.Add(this.cmbKameralar);
            this.Controls.Add(this.pbTracker);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Watch Dog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTracker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCapture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHassas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTracker;
        private System.Windows.Forms.ComboBox cmbKameralar;
        private System.Windows.Forms.Button btStartStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer tmrSipsak;
        private System.Windows.Forms.PictureBox pbCapture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtMachine;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGozat;
        private System.Windows.Forms.Label lblStat;
        private System.Windows.Forms.CheckBox chkLokal;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudHassas;
        private System.Windows.Forms.Label label7;
    }
}

