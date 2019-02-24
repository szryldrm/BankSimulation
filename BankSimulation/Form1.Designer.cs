namespace ConsAssig4
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.fifoMlblMinute = new MetroFramework.Controls.MetroLabel();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.mTxtJobsCount = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnVezne4 = new System.Windows.Forms.Button();
            this.btnVezne3 = new System.Windows.Forms.Button();
            this.btnVezne2 = new System.Windows.Forms.Button();
            this.btnVezne1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.ljfMlblSecond = new MetroFramework.Controls.MetroLabel();
            this.mLblAyrac3 = new MetroFramework.Controls.MetroLabel();
            this.sjfMlblSecond = new MetroFramework.Controls.MetroLabel();
            this.mLblAyrac2 = new MetroFramework.Controls.MetroLabel();
            this.ljfMlblMinute = new MetroFramework.Controls.MetroLabel();
            this.fifoMlblSecond = new MetroFramework.Controls.MetroLabel();
            this.sjfMlblMinute = new MetroFramework.Controls.MetroLabel();
            this.mLblAyrac1 = new MetroFramework.Controls.MetroLabel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // metroButton1
            // 
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.Location = new System.Drawing.Point(32, 42);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(88, 31);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "Normal";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton2.Location = new System.Drawing.Point(140, 42);
            this.metroButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(88, 31);
            this.metroButton2.TabIndex = 7;
            this.metroButton2.Text = "Longer";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton3.Location = new System.Drawing.Point(245, 42);
            this.metroButton3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(88, 31);
            this.metroButton3.TabIndex = 8;
            this.metroButton3.Text = "Shortest";
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // fifoMlblMinute
            // 
            this.fifoMlblMinute.AutoSize = true;
            this.fifoMlblMinute.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.fifoMlblMinute.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.fifoMlblMinute.Location = new System.Drawing.Point(21, 53);
            this.fifoMlblMinute.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fifoMlblMinute.Name = "fifoMlblMinute";
            this.fifoMlblMinute.Size = new System.Drawing.Size(32, 25);
            this.fifoMlblMinute.TabIndex = 9;
            this.fifoMlblMinute.Text = "00";
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(11, 80);
            this.metroProgressBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(353, 28);
            this.metroProgressBar1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroProgressBar1.TabIndex = 5;
            this.metroProgressBar1.Tag = "";
            this.metroProgressBar1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(265, 37);
            this.metroButton4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(100, 27);
            this.metroButton4.TabIndex = 10;
            this.metroButton4.Text = "Create Jobs";
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // mTxtJobsCount
            // 
            // 
            // 
            // 
            this.mTxtJobsCount.CustomButton.Image = null;
            this.mTxtJobsCount.CustomButton.Location = new System.Drawing.Point(218, 1);
            this.mTxtJobsCount.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mTxtJobsCount.CustomButton.Name = "";
            this.mTxtJobsCount.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mTxtJobsCount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxtJobsCount.CustomButton.TabIndex = 1;
            this.mTxtJobsCount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxtJobsCount.CustomButton.UseSelectable = true;
            this.mTxtJobsCount.CustomButton.Visible = false;
            this.mTxtJobsCount.DisplayIcon = true;
            this.mTxtJobsCount.Icon = ((System.Drawing.Image)(resources.GetObject("mTxtJobsCount.Icon")));
            this.mTxtJobsCount.Lines = new string[0];
            this.mTxtJobsCount.Location = new System.Drawing.Point(11, 37);
            this.mTxtJobsCount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mTxtJobsCount.MaxLength = 32767;
            this.mTxtJobsCount.Name = "mTxtJobsCount";
            this.mTxtJobsCount.PasswordChar = '\0';
            this.mTxtJobsCount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtJobsCount.SelectedText = "";
            this.mTxtJobsCount.SelectionLength = 0;
            this.mTxtJobsCount.SelectionStart = 0;
            this.mTxtJobsCount.ShowClearButton = true;
            this.mTxtJobsCount.Size = new System.Drawing.Size(244, 27);
            this.mTxtJobsCount.Style = MetroFramework.MetroColorStyle.Orange;
            this.mTxtJobsCount.TabIndex = 11;
            this.mTxtJobsCount.UseSelectable = true;
            this.mTxtJobsCount.WaterMark = "Enter Jobs Count";
            this.mTxtJobsCount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxtJobsCount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mTxtJobsCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mTxtJobsCount_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mTxtJobsCount);
            this.groupBox1.Controls.Add(this.metroProgressBar1);
            this.groupBox1.Controls.Add(this.metroButton4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(9, 68);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(376, 123);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jobs Create";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Controls.Add(this.metroLabel1);
            this.groupBox2.Controls.Add(this.btnVezne4);
            this.groupBox2.Controls.Add(this.btnVezne3);
            this.groupBox2.Controls.Add(this.btnVezne2);
            this.groupBox2.Controls.Add(this.btnVezne1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(407, 68);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(368, 239);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cashiers";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(238, 106);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(0, 0);
            this.metroLabel4.TabIndex = 4;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(68, 106);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(0, 0);
            this.metroLabel3.TabIndex = 4;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(238, 208);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(0, 0);
            this.metroLabel2.TabIndex = 4;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(68, 208);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(0, 0);
            this.metroLabel1.TabIndex = 4;
            // 
            // btnVezne4
            // 
            this.btnVezne4.BackColor = System.Drawing.Color.Lime;
            this.btnVezne4.Enabled = false;
            this.btnVezne4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVezne4.Location = new System.Drawing.Point(201, 28);
            this.btnVezne4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVezne4.Name = "btnVezne4";
            this.btnVezne4.Size = new System.Drawing.Size(123, 69);
            this.btnVezne4.TabIndex = 3;
            this.btnVezne4.Text = "Cashier 4";
            this.btnVezne4.UseVisualStyleBackColor = false;
            // 
            // btnVezne3
            // 
            this.btnVezne3.BackColor = System.Drawing.Color.Lime;
            this.btnVezne3.Enabled = false;
            this.btnVezne3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVezne3.Location = new System.Drawing.Point(31, 28);
            this.btnVezne3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVezne3.Name = "btnVezne3";
            this.btnVezne3.Size = new System.Drawing.Size(123, 69);
            this.btnVezne3.TabIndex = 2;
            this.btnVezne3.Text = "Cashier 3";
            this.btnVezne3.UseVisualStyleBackColor = false;
            // 
            // btnVezne2
            // 
            this.btnVezne2.BackColor = System.Drawing.Color.Lime;
            this.btnVezne2.Enabled = false;
            this.btnVezne2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVezne2.Location = new System.Drawing.Point(201, 129);
            this.btnVezne2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVezne2.Name = "btnVezne2";
            this.btnVezne2.Size = new System.Drawing.Size(123, 69);
            this.btnVezne2.TabIndex = 1;
            this.btnVezne2.Text = "Cashier 2";
            this.btnVezne2.UseVisualStyleBackColor = false;
            // 
            // btnVezne1
            // 
            this.btnVezne1.BackColor = System.Drawing.Color.Lime;
            this.btnVezne1.Enabled = false;
            this.btnVezne1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVezne1.Location = new System.Drawing.Point(31, 129);
            this.btnVezne1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVezne1.Name = "btnVezne1";
            this.btnVezne1.Size = new System.Drawing.Size(123, 69);
            this.btnVezne1.TabIndex = 0;
            this.btnVezne1.Text = "Cashier 1";
            this.btnVezne1.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.metroLabel7);
            this.groupBox3.Controls.Add(this.metroLabel6);
            this.groupBox3.Controls.Add(this.metroLabel5);
            this.groupBox3.Controls.Add(this.ljfMlblSecond);
            this.groupBox3.Controls.Add(this.mLblAyrac3);
            this.groupBox3.Controls.Add(this.sjfMlblSecond);
            this.groupBox3.Controls.Add(this.mLblAyrac2);
            this.groupBox3.Controls.Add(this.ljfMlblMinute);
            this.groupBox3.Controls.Add(this.fifoMlblSecond);
            this.groupBox3.Controls.Add(this.sjfMlblMinute);
            this.groupBox3.Controls.Add(this.mLblAyrac1);
            this.groupBox3.Controls.Add(this.fifoMlblMinute);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(9, 339);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(376, 109);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Time Elapseds";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(260, 25);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(100, 15);
            this.metroLabel7.TabIndex = 0;
            this.metroLabel7.Text = "Longest Job First";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(149, 25);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(104, 15);
            this.metroLabel6.TabIndex = 0;
            this.metroLabel6.Text = "Shortest Job First";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(3, 25);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(136, 15);
            this.metroLabel5.TabIndex = 0;
            this.metroLabel5.Text = "First Come First Served";
            // 
            // ljfMlblSecond
            // 
            this.ljfMlblSecond.AutoSize = true;
            this.ljfMlblSecond.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ljfMlblSecond.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.ljfMlblSecond.Location = new System.Drawing.Point(304, 53);
            this.ljfMlblSecond.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ljfMlblSecond.Name = "ljfMlblSecond";
            this.ljfMlblSecond.Size = new System.Drawing.Size(32, 25);
            this.ljfMlblSecond.TabIndex = 9;
            this.ljfMlblSecond.Text = "00";
            // 
            // mLblAyrac3
            // 
            this.mLblAyrac3.AutoSize = true;
            this.mLblAyrac3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mLblAyrac3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mLblAyrac3.Location = new System.Drawing.Point(294, 53);
            this.mLblAyrac3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mLblAyrac3.Name = "mLblAyrac3";
            this.mLblAyrac3.Size = new System.Drawing.Size(17, 25);
            this.mLblAyrac3.TabIndex = 9;
            this.mLblAyrac3.Text = ":";
            // 
            // sjfMlblSecond
            // 
            this.sjfMlblSecond.AutoSize = true;
            this.sjfMlblSecond.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.sjfMlblSecond.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.sjfMlblSecond.Location = new System.Drawing.Point(193, 53);
            this.sjfMlblSecond.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sjfMlblSecond.Name = "sjfMlblSecond";
            this.sjfMlblSecond.Size = new System.Drawing.Size(32, 25);
            this.sjfMlblSecond.TabIndex = 9;
            this.sjfMlblSecond.Text = "00";
            // 
            // mLblAyrac2
            // 
            this.mLblAyrac2.AutoSize = true;
            this.mLblAyrac2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mLblAyrac2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mLblAyrac2.Location = new System.Drawing.Point(183, 53);
            this.mLblAyrac2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mLblAyrac2.Name = "mLblAyrac2";
            this.mLblAyrac2.Size = new System.Drawing.Size(17, 25);
            this.mLblAyrac2.TabIndex = 9;
            this.mLblAyrac2.Text = ":";
            // 
            // ljfMlblMinute
            // 
            this.ljfMlblMinute.AutoSize = true;
            this.ljfMlblMinute.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ljfMlblMinute.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.ljfMlblMinute.Location = new System.Drawing.Point(269, 53);
            this.ljfMlblMinute.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ljfMlblMinute.Name = "ljfMlblMinute";
            this.ljfMlblMinute.Size = new System.Drawing.Size(32, 25);
            this.ljfMlblMinute.TabIndex = 9;
            this.ljfMlblMinute.Text = "00";
            // 
            // fifoMlblSecond
            // 
            this.fifoMlblSecond.AutoSize = true;
            this.fifoMlblSecond.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.fifoMlblSecond.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.fifoMlblSecond.Location = new System.Drawing.Point(56, 53);
            this.fifoMlblSecond.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fifoMlblSecond.Name = "fifoMlblSecond";
            this.fifoMlblSecond.Size = new System.Drawing.Size(32, 25);
            this.fifoMlblSecond.TabIndex = 9;
            this.fifoMlblSecond.Text = "00";
            // 
            // sjfMlblMinute
            // 
            this.sjfMlblMinute.AutoSize = true;
            this.sjfMlblMinute.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.sjfMlblMinute.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.sjfMlblMinute.Location = new System.Drawing.Point(158, 53);
            this.sjfMlblMinute.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sjfMlblMinute.Name = "sjfMlblMinute";
            this.sjfMlblMinute.Size = new System.Drawing.Size(32, 25);
            this.sjfMlblMinute.TabIndex = 9;
            this.sjfMlblMinute.Text = "00";
            // 
            // mLblAyrac1
            // 
            this.mLblAyrac1.AutoSize = true;
            this.mLblAyrac1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mLblAyrac1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mLblAyrac1.Location = new System.Drawing.Point(46, 53);
            this.mLblAyrac1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mLblAyrac1.Name = "mLblAyrac1";
            this.mLblAyrac1.Size = new System.Drawing.Size(17, 25);
            this.mLblAyrac1.TabIndex = 9;
            this.mLblAyrac1.Text = ":";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.metroButton1);
            this.groupBox4.Controls.Add(this.metroButton2);
            this.groupBox4.Controls.Add(this.metroButton3);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(9, 210);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(376, 110);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Algorithms";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.listBox1);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.Location = new System.Drawing.Point(407, 319);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Size = new System.Drawing.Size(368, 129);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Jobs Waiting";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(17, 20);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(326, 94);
            this.listBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 456);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(11, 33, 11, 11);
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Simulation";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroLabel fifoMlblMinute;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroTextBox mTxtJobsCount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnVezne4;
        private System.Windows.Forms.Button btnVezne3;
        private System.Windows.Forms.Button btnVezne2;
        private System.Windows.Forms.Button btnVezne1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel fifoMlblSecond;
        private MetroFramework.Controls.MetroLabel mLblAyrac1;
        private MetroFramework.Controls.MetroLabel ljfMlblSecond;
        private MetroFramework.Controls.MetroLabel mLblAyrac3;
        private MetroFramework.Controls.MetroLabel sjfMlblSecond;
        private MetroFramework.Controls.MetroLabel mLblAyrac2;
        private MetroFramework.Controls.MetroLabel ljfMlblMinute;
        private MetroFramework.Controls.MetroLabel sjfMlblMinute;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox listBox1;
    }
}

