﻿namespace ReadApp
{
    partial class MainForm
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fitScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vesselDetectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tbFrame = new System.Windows.Forms.TextBox();
            this.labelTotalFame = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewPatientTag = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewAllTag = new System.Windows.Forms.DataGridView();
            this.labelFrameSize = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.labelFileName = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelZoom = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxMain = new YLScsImage.ImagePanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.groupBoxMediaPlayer = new System.Windows.Forms.GroupBox();
            this.buttonEditFramePerSecond = new System.Windows.Forms.Button();
            this.labelFramePerSecond = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.groupBoxImage = new System.Windows.Forms.GroupBox();
            this.buttonZoomOut = new System.Windows.Forms.Button();
            this.buttonZoomIn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxTool = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatientTag)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllTag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxMediaPlayer.SuspendLayout();
            this.groupBoxImage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxTool.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fitScreenToolStripMenuItem,
            this.numberToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // fitScreenToolStripMenuItem
            // 
            this.fitScreenToolStripMenuItem.Name = "fitScreenToolStripMenuItem";
            this.fitScreenToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.fitScreenToolStripMenuItem.Text = "Fit Screen";
            this.fitScreenToolStripMenuItem.Click += new System.EventHandler(this.fitScreenToolStripMenuItem_Click);
            // 
            // numberToolStripMenuItem
            // 
            this.numberToolStripMenuItem.Name = "numberToolStripMenuItem";
            this.numberToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.numberToolStripMenuItem.Text = "Frame per second";
            this.numberToolStripMenuItem.Click += new System.EventHandler(this.numberToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vesselDetectToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // vesselDetectToolStripMenuItem
            // 
            this.vesselDetectToolStripMenuItem.Name = "vesselDetectToolStripMenuItem";
            this.vesselDetectToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.vesselDetectToolStripMenuItem.Text = "Vessel Detect";
            this.vesselDetectToolStripMenuItem.Click += new System.EventHandler(this.vesselDetectToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1255, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tbFrame
            // 
            this.tbFrame.Location = new System.Drawing.Point(47, 59);
            this.tbFrame.Name = "tbFrame";
            this.tbFrame.Size = new System.Drawing.Size(25, 20);
            this.tbFrame.TabIndex = 2;
            this.tbFrame.TextChanged += new System.EventHandler(this.tbFrame_TextChanged);
            this.tbFrame.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbFrame_KeyDown);
            this.tbFrame.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFrame_KeyPress);
            // 
            // labelTotalFame
            // 
            this.labelTotalFame.AutoSize = true;
            this.labelTotalFame.Location = new System.Drawing.Point(78, 62);
            this.labelTotalFame.Name = "labelTotalFame";
            this.labelTotalFame.Size = new System.Drawing.Size(18, 13);
            this.labelTotalFame.TabIndex = 7;
            this.labelTotalFame.Text = "/0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Frame: ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(350, 661);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewPatientTag);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(342, 635);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Patient Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPatientTag
            // 
            this.dataGridViewPatientTag.AllowUserToAddRows = false;
            this.dataGridViewPatientTag.AllowUserToDeleteRows = false;
            this.dataGridViewPatientTag.AllowUserToResizeRows = false;
            this.dataGridViewPatientTag.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPatientTag.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewPatientTag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPatientTag.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewPatientTag.Name = "dataGridViewPatientTag";
            this.dataGridViewPatientTag.ReadOnly = true;
            this.dataGridViewPatientTag.RowHeadersVisible = false;
            this.dataGridViewPatientTag.Size = new System.Drawing.Size(336, 629);
            this.dataGridViewPatientTag.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewAllTag);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(342, 635);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "All Tags";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAllTag
            // 
            this.dataGridViewAllTag.AllowUserToAddRows = false;
            this.dataGridViewAllTag.AllowUserToDeleteRows = false;
            this.dataGridViewAllTag.AllowUserToResizeRows = false;
            this.dataGridViewAllTag.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAllTag.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewAllTag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAllTag.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewAllTag.Name = "dataGridViewAllTag";
            this.dataGridViewAllTag.ReadOnly = true;
            this.dataGridViewAllTag.RowHeadersVisible = false;
            this.dataGridViewAllTag.Size = new System.Drawing.Size(336, 629);
            this.dataGridViewAllTag.TabIndex = 1;
            // 
            // labelFrameSize
            // 
            this.labelFrameSize.AutoSize = true;
            this.labelFrameSize.Location = new System.Drawing.Point(69, 80);
            this.labelFrameSize.Name = "labelFrameSize";
            this.labelFrameSize.Size = new System.Drawing.Size(24, 13);
            this.labelFrameSize.TabIndex = 9;
            this.labelFrameSize.Text = "0x0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Frame size:";
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.BackColor = System.Drawing.SystemColors.Window;
            this.trackBar1.Location = new System.Drawing.Point(41, 23);
            this.trackBar1.Maximum = 30;
            this.trackBar1.Minimum = 5;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(90, 30);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(69, 103);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(25, 13);
            this.labelFileName.TabIndex = 12;
            this.labelFileName.Text = "Null";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "File name:";
            // 
            // labelZoom
            // 
            this.labelZoom.AutoSize = true;
            this.labelZoom.Location = new System.Drawing.Point(69, 52);
            this.labelZoom.Name = "labelZoom";
            this.labelZoom.Size = new System.Drawing.Size(33, 13);
            this.labelZoom.TabIndex = 10;
            this.labelZoom.Text = "100%";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.splitContainer1.Location = new System.Drawing.Point(218, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.AutoScrollMinSize = new System.Drawing.Size(600, 600);
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Black;
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBoxMain);
            this.splitContainer1.Panel1MinSize = 690;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel2MinSize = 330;
            this.splitContainer1.Size = new System.Drawing.Size(1042, 661);
            this.splitContainer1.SplitterDistance = 690;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(690, 661);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.BackColor = System.Drawing.Color.Black;
            this.pictureBoxMain.CanvasSize = new System.Drawing.Size(60, 40);
            this.pictureBoxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxMain.ForeColor = System.Drawing.Color.Transparent;
            this.pictureBoxMain.Image = null;
            this.pictureBoxMain.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.pictureBoxMain.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(690, 661);
            this.pictureBoxMain.TabIndex = 0;
            this.pictureBoxMain.Zoom = 1F;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonOpen);
            this.groupBox1.Controls.Add(this.buttonExport);
            this.groupBox1.Location = new System.Drawing.Point(20, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 60);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Action";
            // 
            // buttonOpen
            // 
            this.buttonOpen.BackColor = System.Drawing.Color.Transparent;
            this.buttonOpen.FlatAppearance.BorderSize = 0;
            this.buttonOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpen.Image = global::ReadApp.Properties.Resources.Open_16x16;
            this.buttonOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOpen.Location = new System.Drawing.Point(6, 19);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(60, 30);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonOpen.UseVisualStyleBackColor = false;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.FlatAppearance.BorderSize = 0;
            this.buttonExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExport.Image = global::ReadApp.Properties.Resources.ExportFile_16x16;
            this.buttonExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExport.Location = new System.Drawing.Point(72, 19);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(60, 30);
            this.buttonExport.TabIndex = 13;
            this.buttonExport.Text = "Export";
            this.buttonExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // groupBoxMediaPlayer
            // 
            this.groupBoxMediaPlayer.Controls.Add(this.buttonEditFramePerSecond);
            this.groupBoxMediaPlayer.Controls.Add(this.labelFramePerSecond);
            this.groupBoxMediaPlayer.Controls.Add(this.label2);
            this.groupBoxMediaPlayer.Controls.Add(this.btnNext);
            this.groupBoxMediaPlayer.Controls.Add(this.btnPlay);
            this.groupBoxMediaPlayer.Controls.Add(this.btnPrevious);
            this.groupBoxMediaPlayer.Controls.Add(this.btnStop);
            this.groupBoxMediaPlayer.Controls.Add(this.tbFrame);
            this.groupBoxMediaPlayer.Controls.Add(this.labelTotalFame);
            this.groupBoxMediaPlayer.Controls.Add(this.label1);
            this.groupBoxMediaPlayer.Location = new System.Drawing.Point(20, 70);
            this.groupBoxMediaPlayer.Name = "groupBoxMediaPlayer";
            this.groupBoxMediaPlayer.Size = new System.Drawing.Size(180, 122);
            this.groupBoxMediaPlayer.TabIndex = 15;
            this.groupBoxMediaPlayer.TabStop = false;
            this.groupBoxMediaPlayer.Text = "Media Player";
            // 
            // buttonEditFramePerSecond
            // 
            this.buttonEditFramePerSecond.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEditFramePerSecond.Location = new System.Drawing.Point(134, 89);
            this.buttonEditFramePerSecond.Name = "buttonEditFramePerSecond";
            this.buttonEditFramePerSecond.Size = new System.Drawing.Size(38, 23);
            this.buttonEditFramePerSecond.TabIndex = 10;
            this.buttonEditFramePerSecond.Text = "Edit";
            this.buttonEditFramePerSecond.UseVisualStyleBackColor = true;
            this.buttonEditFramePerSecond.Click += new System.EventHandler(this.buttonEditFramePerSecond_Click);
            // 
            // labelFramePerSecond
            // 
            this.labelFramePerSecond.AutoSize = true;
            this.labelFramePerSecond.Location = new System.Drawing.Point(107, 94);
            this.labelFramePerSecond.Name = "labelFramePerSecond";
            this.labelFramePerSecond.Size = new System.Drawing.Size(19, 13);
            this.labelFramePerSecond.TabIndex = 9;
            this.labelFramePerSecond.Text = "12";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Frame per second:";
            // 
            // btnNext
            // 
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Image = global::ReadApp.Properties.Resources.Next_16x16;
            this.btnNext.Location = new System.Drawing.Point(78, 19);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(30, 30);
            this.btnNext.TabIndex = 1;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Image = global::ReadApp.Properties.Resources.pause_blue;
            this.btnPlay.Location = new System.Drawing.Point(42, 19);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(30, 30);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Image = global::ReadApp.Properties.Resources.Prev_16x16;
            this.btnPrevious.Location = new System.Drawing.Point(6, 19);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(30, 30);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Image = global::ReadApp.Properties.Resources.stop_red;
            this.btnStop.Location = new System.Drawing.Point(114, 19);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(30, 30);
            this.btnStop.TabIndex = 1;
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // groupBoxImage
            // 
            this.groupBoxImage.Controls.Add(this.trackBar1);
            this.groupBoxImage.Controls.Add(this.buttonZoomOut);
            this.groupBoxImage.Controls.Add(this.buttonZoomIn);
            this.groupBoxImage.Controls.Add(this.labelFileName);
            this.groupBoxImage.Controls.Add(this.labelZoom);
            this.groupBoxImage.Controls.Add(this.label12);
            this.groupBoxImage.Controls.Add(this.label5);
            this.groupBoxImage.Controls.Add(this.labelFrameSize);
            this.groupBoxImage.Location = new System.Drawing.Point(20, 198);
            this.groupBoxImage.Name = "groupBoxImage";
            this.groupBoxImage.Size = new System.Drawing.Size(180, 125);
            this.groupBoxImage.TabIndex = 16;
            this.groupBoxImage.TabStop = false;
            this.groupBoxImage.Text = "Image";
            // 
            // buttonZoomOut
            // 
            this.buttonZoomOut.BackColor = System.Drawing.Color.Transparent;
            this.buttonZoomOut.FlatAppearance.BorderSize = 0;
            this.buttonZoomOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZoomOut.Image = global::ReadApp.Properties.Resources.ZoomOut_16x16;
            this.buttonZoomOut.Location = new System.Drawing.Point(137, 19);
            this.buttonZoomOut.Name = "buttonZoomOut";
            this.buttonZoomOut.Size = new System.Drawing.Size(30, 30);
            this.buttonZoomOut.TabIndex = 5;
            this.buttonZoomOut.UseVisualStyleBackColor = false;
            this.buttonZoomOut.Click += new System.EventHandler(this.buttonZoomOut_Click);
            // 
            // buttonZoomIn
            // 
            this.buttonZoomIn.BackColor = System.Drawing.Color.Transparent;
            this.buttonZoomIn.FlatAppearance.BorderSize = 0;
            this.buttonZoomIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZoomIn.Image = global::ReadApp.Properties.Resources.ZoomIn_16x16;
            this.buttonZoomIn.Location = new System.Drawing.Point(6, 19);
            this.buttonZoomIn.Name = "buttonZoomIn";
            this.buttonZoomIn.Size = new System.Drawing.Size(30, 30);
            this.buttonZoomIn.TabIndex = 6;
            this.buttonZoomIn.UseVisualStyleBackColor = false;
            this.buttonZoomIn.Click += new System.EventHandler(this.buttonZoomIn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.groupBoxTool);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBoxMediaPlayer);
            this.panel1.Controls.Add(this.groupBoxImage);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 661);
            this.panel1.TabIndex = 17;
            // 
            // groupBoxTool
            // 
            this.groupBoxTool.Controls.Add(this.button1);
            this.groupBoxTool.Location = new System.Drawing.Point(20, 329);
            this.groupBoxTool.Name = "groupBoxTool";
            this.groupBoxTool.Size = new System.Drawing.Size(180, 57);
            this.groupBoxTool.TabIndex = 17;
            this.groupBoxTool.TabStop = false;
            this.groupBoxTool.Text = "Tool";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::ReadApp.Properties.Resources.cog_start;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 14;
            this.button1.Text = "Vessel Detect";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.detectVesselbutton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 687);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DICOM Viewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatientTag)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllTag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBoxMediaPlayer.ResumeLayout(false);
            this.groupBoxMediaPlayer.PerformLayout();
            this.groupBoxImage.ResumeLayout(false);
            this.groupBoxImage.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBoxTool.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonZoomOut;
        private System.Windows.Forms.Button buttonZoomIn;
        private System.Windows.Forms.Label labelFrameSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelTotalFame;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewPatientTag;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox tbFrame;
        private System.Windows.Forms.DataGridView dataGridViewAllTag;
        private System.Windows.Forms.Label labelZoom;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Label label12;
        private YLScsImage.ImagePanel pictureBoxMain;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.GroupBox groupBoxMediaPlayer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vesselDetectToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxTool;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem fitScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label labelFramePerSecond;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Button buttonEditFramePerSecond;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}