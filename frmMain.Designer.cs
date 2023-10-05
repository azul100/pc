namespace DriveStat
{
	partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGeekpedia = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.treeDrives = new System.Windows.Forms.TreeView();
            this.imgDriveIcons = new System.Windows.Forms.ImageList(this.components);
            this.stsStandard = new System.Windows.Forms.StatusStrip();
            this.stsAppInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lnkVolumeName = new System.Windows.Forms.LinkLabel();
            this.imgDriveIcon = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDriveDetails = new System.Windows.Forms.Panel();
            this.pnlBigPie = new System.Drawing.PieChart.PieChartControl();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.chkRotate = new System.Windows.Forms.CheckBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.pnlSmallPie = new System.Windows.Forms.Panel();
            this.lblFileSystem = new System.Windows.Forms.Label();
            this.lblUsedSpace = new System.Windows.Forms.Label();
            this.lblTotalSize = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFreeSpace = new System.Windows.Forms.Label();
            this.tmrAngle = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.stsStandard.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.pnlDriveDetails.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(676, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(92, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGeekpedia,
            this.toolStripSeparator1,
            this.mnuAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // mnuGeekpedia
            // 
            this.mnuGeekpedia.Image = global::github.Properties.Resources.Geekpedia;
            this.mnuGeekpedia.Name = "mnuGeekpedia";
            this.mnuGeekpedia.Size = new System.Drawing.Size(156, 22);
            this.mnuGeekpedia.Text = "Geekpedia.com";
            this.mnuGeekpedia.Click += new System.EventHandler(this.mnuGeekpedia_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(153, 6);
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(156, 22);
            this.mnuAbout.Text = "About";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // treeDrives
            // 
            this.treeDrives.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeDrives.ImageIndex = 0;
            this.treeDrives.ImageList = this.imgDriveIcons;
            this.treeDrives.Location = new System.Drawing.Point(0, 24);
            this.treeDrives.Name = "treeDrives";
            this.treeDrives.SelectedImageIndex = 3;
            this.treeDrives.Size = new System.Drawing.Size(148, 358);
            this.treeDrives.StateImageList = this.imgDriveIcons;
            this.treeDrives.TabIndex = 2;
            this.treeDrives.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeDrives_AfterSelect);
            // 
            // imgDriveIcons
            // 
            this.imgDriveIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgDriveIcons.ImageStream")));
            this.imgDriveIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imgDriveIcons.Images.SetKeyName(0, "CDDRive.ico");
            this.imgDriveIcons.Images.SetKeyName(1, "DVDDrive.ico");
            this.imgDriveIcons.Images.SetKeyName(2, "FloppyDrive.ico");
            this.imgDriveIcons.Images.SetKeyName(3, "HDDrive.ico");
            this.imgDriveIcons.Images.SetKeyName(4, "NetworkConnectedDrive.ico");
            this.imgDriveIcons.Images.SetKeyName(5, "NetworkDisconnectedDrive.ico");
            this.imgDriveIcons.Images.SetKeyName(6, "RamDrive.ico");
            this.imgDriveIcons.Images.SetKeyName(7, "UnknownDrive.ico");
            this.imgDriveIcons.Images.SetKeyName(8, "WindowsDrive.ico");
            // 
            // stsStandard
            // 
            this.stsStandard.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsAppInfo});
            this.stsStandard.Location = new System.Drawing.Point(0, 382);
            this.stsStandard.Name = "stsStandard";
            this.stsStandard.Size = new System.Drawing.Size(676, 22);
            this.stsStandard.TabIndex = 3;
            this.stsStandard.Text = "Done";
            // 
            // stsAppInfo
            // 
            this.stsAppInfo.Name = "stsAppInfo";
            this.stsAppInfo.Size = new System.Drawing.Size(118, 17);
            this.stsAppInfo.Text = "toolStripStatusLabel1";
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.SystemColors.Control;
            this.pnlTitle.Controls.Add(this.lnkVolumeName);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(148, 24);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(528, 54);
            this.pnlTitle.TabIndex = 5;
            this.pnlTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTitle_Paint);
            // 
            // lnkVolumeName
            // 
            this.lnkVolumeName.AutoSize = true;
            this.lnkVolumeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkVolumeName.Location = new System.Drawing.Point(48, 17);
            this.lnkVolumeName.Name = "lnkVolumeName";
            this.lnkVolumeName.Size = new System.Drawing.Size(123, 17);
            this.lnkVolumeName.TabIndex = 6;
            this.lnkVolumeName.TabStop = true;
            this.lnkVolumeName.Text = "Drive is not ready.";
            this.lnkVolumeName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkVolumeName_LinkClicked);
            // 
            // imgDriveIcon
            // 
            this.imgDriveIcon.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgDriveIcon.ImageSize = new System.Drawing.Size(32, 32);
            this.imgDriveIcon.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "File System: ";
            // 
            // pnlDriveDetails
            // 
            this.pnlDriveDetails.Controls.Add(this.pnlBigPie);
            this.pnlDriveDetails.Controls.Add(this.pnlInfo);
            this.pnlDriveDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDriveDetails.Location = new System.Drawing.Point(148, 78);
            this.pnlDriveDetails.Name = "pnlDriveDetails";
            this.pnlDriveDetails.Size = new System.Drawing.Size(528, 304);
            this.pnlDriveDetails.TabIndex = 7;
            // 
            // pnlBigPie
            // 
            this.pnlBigPie.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBigPie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBigPie.Location = new System.Drawing.Point(191, 0);
            this.pnlBigPie.Name = "pnlBigPie";
            this.pnlBigPie.Size = new System.Drawing.Size(337, 304);
            this.pnlBigPie.TabIndex = 15;
            this.pnlBigPie.ToolTips = null;
            // 
            // pnlInfo
            // 
            this.pnlInfo.Controls.Add(this.chkRotate);
            this.pnlInfo.Controls.Add(this.label1);
            this.pnlInfo.Controls.Add(this.Label5);
            this.pnlInfo.Controls.Add(this.pnlSmallPie);
            this.pnlInfo.Controls.Add(this.lblFileSystem);
            this.pnlInfo.Controls.Add(this.lblUsedSpace);
            this.pnlInfo.Controls.Add(this.lblTotalSize);
            this.pnlInfo.Controls.Add(this.label3);
            this.pnlInfo.Controls.Add(this.label2);
            this.pnlInfo.Controls.Add(this.lblFreeSpace);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(191, 304);
            this.pnlInfo.TabIndex = 17;
            // 
            // chkRotate
            // 
            this.chkRotate.AutoSize = true;
            this.chkRotate.Location = new System.Drawing.Point(8, 215);
            this.chkRotate.Name = "chkRotate";
            this.chkRotate.Size = new System.Drawing.Size(76, 17);
            this.chkRotate.TabIndex = 15;
            this.chkRotate.Text = "Rotate Pie";
            this.chkRotate.CheckedChanged += new System.EventHandler(this.chkRotate_CheckedChanged);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(7, 75);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(57, 13);
            this.Label5.TabIndex = 7;
            this.Label5.Text = "Total Size:";
            // 
            // pnlSmallPie
            // 
            this.pnlSmallPie.Location = new System.Drawing.Point(8, 99);
            this.pnlSmallPie.Name = "pnlSmallPie";
            this.pnlSmallPie.Size = new System.Drawing.Size(110, 110);
            this.pnlSmallPie.TabIndex = 14;
            this.pnlSmallPie.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSmallPie_Paint);
            // 
            // lblFileSystem
            // 
            this.lblFileSystem.AutoSize = true;
            this.lblFileSystem.Location = new System.Drawing.Point(76, 7);
            this.lblFileSystem.Name = "lblFileSystem";
            this.lblFileSystem.Size = new System.Drawing.Size(53, 13);
            this.lblFileSystem.TabIndex = 8;
            this.lblFileSystem.Text = "Unknown";
            // 
            // lblUsedSpace
            // 
            this.lblUsedSpace.AutoSize = true;
            this.lblUsedSpace.Location = new System.Drawing.Point(76, 52);
            this.lblUsedSpace.Name = "lblUsedSpace";
            this.lblUsedSpace.Size = new System.Drawing.Size(53, 13);
            this.lblUsedSpace.TabIndex = 13;
            this.lblUsedSpace.Text = "Unknown";
            // 
            // lblTotalSize
            // 
            this.lblTotalSize.AutoSize = true;
            this.lblTotalSize.Location = new System.Drawing.Point(76, 75);
            this.lblTotalSize.Name = "lblTotalSize";
            this.lblTotalSize.Size = new System.Drawing.Size(53, 13);
            this.lblTotalSize.TabIndex = 9;
            this.lblTotalSize.Text = "Unknown";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Used Space:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Free Space:";
            // 
            // lblFreeSpace
            // 
            this.lblFreeSpace.AutoSize = true;
            this.lblFreeSpace.Location = new System.Drawing.Point(76, 30);
            this.lblFreeSpace.Name = "lblFreeSpace";
            this.lblFreeSpace.Size = new System.Drawing.Size(53, 13);
            this.lblFreeSpace.TabIndex = 11;
            this.lblFreeSpace.Text = "Unknown";
            // 
            // tmrAngle
            // 
            this.tmrAngle.Interval = 10;
            this.tmrAngle.Tick += new System.EventHandler(this.tmrAngle_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 404);
            this.Controls.Add(this.pnlDriveDetails);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.treeDrives);
            this.Controls.Add(this.stsStandard);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "github100";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.stsStandard.ResumeLayout(false);
            this.stsStandard.PerformLayout();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlDriveDetails.ResumeLayout(false);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.TreeView treeDrives;
		private System.Windows.Forms.StatusStrip stsStandard;
		private System.Windows.Forms.ImageList imgDriveIcons;
		private System.Windows.Forms.Panel pnlTitle;
		private System.Windows.Forms.ImageList imgDriveIcon;
		private System.Windows.Forms.LinkLabel lnkVolumeName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel pnlDriveDetails;
		private System.Windows.Forms.Label lblFileSystem;
		private System.Windows.Forms.Label Label5;
		private System.Windows.Forms.Label lblTotalSize;
		private System.Windows.Forms.Label lblFreeSpace;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblUsedSpace;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel pnlSmallPie;
		private System.Drawing.PieChart.PieChartControl pnlBigPie;
		private System.Windows.Forms.Panel pnlInfo;
		private System.Windows.Forms.Timer tmrAngle;
		private System.Windows.Forms.CheckBox chkRotate;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mnuAbout;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem mnuExit;
		private System.Windows.Forms.ToolStripMenuItem mnuGeekpedia;
		private System.Windows.Forms.ToolStripStatusLabel stsAppInfo;
	}
}