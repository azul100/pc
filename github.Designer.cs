namespace github
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
			this.mnuMain = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lstDrives = new System.Windows.Forms.ListView();
			this.toolStandard = new System.Windows.Forms.ToolStrip();
			this.imgDriveIcons = new System.Windows.Forms.ImageList(this.components);
			this.colDriveName = new System.Windows.Forms.ColumnHeader();
			this.colVolName = new System.Windows.Forms.ColumnHeader();
			this.mnuMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// mnuMain
			// 
			this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.mnuMain.Location = new System.Drawing.Point(0, 0);
			this.mnuMain.Name = "mnuMain";
			this.mnuMain.Size = new System.Drawing.Size(589, 24);
			this.mnuMain.TabIndex = 1;
			this.mnuMain.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Text = "File";
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Text = "View";
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Text = "Options";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// lstDrives
			// 
			this.lstDrives.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDriveName,
            this.colVolName});
			this.lstDrives.Dock = System.Windows.Forms.DockStyle.Top;
			this.lstDrives.LargeImageList = this.imgDriveIcons;
			this.lstDrives.Location = new System.Drawing.Point(0, 49);
			this.lstDrives.Name = "lstDrives";
			this.lstDrives.Size = new System.Drawing.Size(589, 136);
			this.lstDrives.SmallImageList = this.imgDriveIcons;
			this.lstDrives.TabIndex = 2;
			this.lstDrives.View = System.Windows.Forms.View.Details;
			// 
			// toolStandard
			// 
			this.toolStandard.Location = new System.Drawing.Point(0, 24);
			this.toolStandard.Name = "toolStandard";
			this.toolStandard.Size = new System.Drawing.Size(589, 25);
			this.toolStandard.TabIndex = 3;
			this.toolStandard.Text = "toolStrip1";
			// 
			// imgDriveIcons
			// 
			this.imgDriveIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgDriveIcons.ImageStream")));
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
			// colDriveName
			// 
			this.colDriveName.Text = "Drive";
			this.colDriveName.Width = 88;
			// 
			// colVolName
			// 
			this.colVolName.Text = "Volume Name";
			this.colVolName.Width = 157;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(589, 456);
			this.Controls.Add(this.lstDrives);
			this.Controls.Add(this.toolStandard);
			this.Controls.Add(this.mnuMain);
			this.MainMenuStrip = this.mnuMain;
			this.Name = "frmMain";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.mnuMain.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip mnuMain;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ListView lstDrives;
		private System.Windows.Forms.ToolStrip toolStandard;
		private System.Windows.Forms.ImageList imgDriveIcons;
		private System.Windows.Forms.ColumnHeader colDriveName;
		private System.Windows.Forms.ColumnHeader colVolName;
	}
}

