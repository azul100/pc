using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace github
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			DriveInfo[] driveList = DriveInfo.GetDrives();

			foreach(DriveInfo drive in driveList)
			{
				ListViewItem lvItem = new ListViewItem();
				lstDrives.Items.Add(drive.ToString(), 1);
			}
		}
	}
}