using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
using System.Drawing.PieChart;

namespace DriveStat
{
	public partial class frmMain : Form
	{
		// Create the variables that will later be needing
		private long FreeSpace = 0;
		private long UsedSpace = 0;
		private long TotalSize = 0;
		private float Sweep;
		private float CurrAngle = 0;
		private float FullAngle = 360;
		private Form frmAbout;
		private Rectangle SmallRect;
		LinearGradientBrush BlueBrush;
		LinearGradientBrush RedBrush;

		public frmMain()
		{
			InitializeComponent();
			// Peform the Pie Chart initialization
			InitializeChart();
		}

		private void UpdateChart()
		{
			SetValues();
			SetPieDisplacements();
			SetColors();
			SetTexts();
			SetToolTips();
		}

		private void InitializeChart()
		{
			SetValues();
			SetPieDisplacements();
			SetColors();
			SetTexts();
			SetToolTips();
			// Margins within the panel holding the Pie Chart
			pnlBigPie.LeftMargin = 10;
			pnlBigPie.RightMargin = 30;
			pnlBigPie.TopMargin = 10;
			pnlBigPie.BottomMargin = 35;
			// Setting other properties for the Pie Chart
			pnlBigPie.FitChart = true;
			pnlBigPie.SliceRelativeHeight = 0.25F;
			pnlBigPie.InitialAngle = 0;
			pnlBigPie.EdgeLineWidth = 1;
			pnlBigPie.EdgeColorType = EdgeColorType.DarkerThanSurface;
			pnlBigPie.ShadowStyle = ShadowStyle.GradualShadow;
		}

		private void SetColors()
		{
			ArrayList PieColors = new ArrayList();
			// Blue
			PieColors.Add(Color.FromArgb(122, 0, 74, 240));
			// Red
			PieColors.Add(Color.FromArgb(122, 255, 0, 0));
			pnlBigPie.Colors = (Color[])PieColors.ToArray(typeof(Color));
		}

		private void SetValues()
		{
			ArrayList PieValues = new ArrayList();
			// If there is no information on the free and used space
			// it's probably an empty removable drive
			if ((FreeSpace == 0) & (UsedSpace == 0))
			{
				PieValues.Add(Convert.ToDecimal(1));
			}
			else
			{
				if (FreeSpace != 0)
				{
					PieValues.Add(Convert.ToDecimal(FreeSpace));
				}
				if (UsedSpace != 0)
				{
					PieValues.Add(Convert.ToDecimal(UsedSpace));
				}
			}
			pnlBigPie.Values = (decimal[])PieValues.ToArray(typeof(decimal));
		}

		private void SetPieDisplacements()
		{
			// Replace 0 with 1 or any other value to detach the slices from the Pie Chart
			ArrayList PieDisplacements = new ArrayList();
			PieDisplacements.Add((float)0);
			PieDisplacements.Add((float)0);
			pnlBigPie.SliceRelativeDisplacements = (float[])PieDisplacements.ToArray(typeof(float));
		}

		private void SetTexts()
		{
			// Set the text that will be displayed on the chart
			ArrayList PieTexts = new ArrayList();
			PieTexts.Add(ConvertBytesToMB(FreeSpace) + " MB");
			PieTexts.Add(ConvertBytesToMB(UsedSpace) + " MB");
			pnlBigPie.Texts = (string[])PieTexts.ToArray(typeof(string));
		}

		private void SetToolTips()
		{
			// Set the text for the tooltip
			ArrayList PieToolTips = new ArrayList();
			PieToolTips.Add(FreeSpace + " Bytes");
			PieToolTips.Add(UsedSpace + " Bytes");
			pnlBigPie.ToolTips = (string[])PieToolTips.ToArray(typeof(string));
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			stsAppInfo.Text = "Loading drive list";
			DriveInfo[] driveList = DriveInfo.GetDrives();
			// Loop through the list of drives
			foreach (DriveInfo drive in driveList)
			{
				// It's a HDD
				if (drive.DriveType == DriveType.Fixed)
				{
					treeDrives.Nodes.Add(drive.ToString(), drive.ToString(), 3);
				}
				// It's a CD-ROM, DVD-ROM, CD-RW, DVD+-RW or any other similar drive
				else if (drive.DriveType == DriveType.CDRom)
				{
					treeDrives.Nodes.Add(drive.ToString(), drive.ToString(), 0);
				}
				// It's a floppy drive
				else if (drive.DriveType == DriveType.Removable)
				{
					treeDrives.Nodes.Add(drive.ToString(), drive.ToString(), 2);
				}
				// It's a network drive
				else if (drive.DriveType == DriveType.Network)
				{
					treeDrives.Nodes.Add(drive.ToString(), drive.ToString(), 4);
				}
				// It's a RAM drive
				else if (drive.DriveType == DriveType.Ram)
				{
					treeDrives.Nodes.Add(drive.ToString(), drive.ToString(), 6);
				}
			}
			stsAppInfo.Text = "Done";
		}

		private void treeDrives_AfterSelect(object sender, TreeViewEventArgs e)
		{
			stsAppInfo.Text = "Loading drive information";
			// Get drive information for the currently selected drive
			// To the method we pass the drive path (C:\ for ex.)
			GetDriveInfo(treeDrives.SelectedNode.Name);
			stsAppInfo.Text = "Done";
		}

		private void GetDriveInfo(string driveName)
		{
			// Get drive information for the passed drive path
			DriveInfo driveInfo;
			driveInfo = new DriveInfo(driveName);

			// Clear any icons that can be in imgDriveIcon
			imgDriveIcon.Images.Clear();
			if (driveInfo.DriveType == DriveType.Fixed)
			{
				// Set imgDriveIcon to hold the icon of the current drive
				imgDriveIcon.Images.Add(this.imgDriveIcons.Images[3]);
				// The TreeView requires a SelectedImage for the selected node
				// we don't need that so we set it back to the icon of the current drive
				treeDrives.SelectedImageIndex = 3;
			}
			else if (driveInfo.DriveType == DriveType.CDRom)
			{
				imgDriveIcon.Images.Add(this.imgDriveIcons.Images[0]);
				treeDrives.SelectedImageIndex = 0;
			}
			else if (driveInfo.DriveType == DriveType.Removable)
			{
				imgDriveIcon.Images.Add(this.imgDriveIcons.Images[2]);
				treeDrives.SelectedImageIndex = 2;
			}
			else if (driveInfo.DriveType == DriveType.Network)
			{
				imgDriveIcon.Images.Add(this.imgDriveIcons.Images[4]);
				treeDrives.SelectedImageIndex = 4;
			}
			else if (driveInfo.DriveType == DriveType.Ram)
			{
				imgDriveIcon.Images.Add(this.imgDriveIcons.Images[6]);
				treeDrives.SelectedImageIndex = 6;
			}

			// Try to get the VolumeLabel and Name
			try
			{
				lnkVolumeName.Text = driveInfo.VolumeLabel + " (" + driveInfo.Name + ")";
			}
			catch
			{
				lnkVolumeName.Text = "Drive is not ready.";
			}

			try
			{
				// Initialize the variables
				FreeSpace = driveInfo.TotalFreeSpace;
				TotalSize = driveInfo.TotalSize;
				UsedSpace = TotalSize - FreeSpace;
				// Calculate the sweep (needed for the small pie)
				Sweep = 360f * FreeSpace / TotalSize;
				// Set the labels
				lblFileSystem.Text = driveInfo.DriveFormat;
				lblFreeSpace.Text = this.ConvertBytesToMB(FreeSpace) + " MB";
				lblUsedSpace.Text = this.ConvertBytesToMB(UsedSpace) + " MB";
				lblTotalSize.Text = this.ConvertBytesToMB(TotalSize) + " MB" ;
			}
			catch
			{
				FreeSpace = 0;
				TotalSize = 0;
				UsedSpace = 0;
				Sweep = 0;
				lblFileSystem.Text = "N/A";
				lblFreeSpace.Text = "N/A";
				lblUsedSpace.Text = "N/A";
				lblTotalSize.Text = "N/A";
			}

			// The rectangle in which the small pie will lie
			SmallRect = new Rectangle(5, 5, 85, 85);
			// The two brushes needed to draw the small pie
			BlueBrush = new LinearGradientBrush(SmallRect, Color.FromArgb(0, 57, 150), Color.FromArgb(21, 115, 255), 45);
			RedBrush = new LinearGradientBrush(SmallRect, Color.FromArgb(255, 5, 5), Color.FromArgb(255, 135, 135), 45);

			// Invalidate these two panels so that their content is refreshed
			pnlTitle.Invalidate();
			pnlSmallPie.Invalidate();
			// Call UpdateChart() to update the big Pie Chart
			UpdateChart();
		}

		// A useful method for converting Bytes to MegaBytes
		private string ConvertBytesToMB(Int64 Bytes)
		{
			long MB = Bytes / 1048576;
			return MB.ToString("N");
		}

		// Here we draw the icon for each drive
		private void pnlTitle_Paint(object sender, PaintEventArgs e)
		{
			Rectangle rc = new Rectangle(10, 5, 32, 32);
			e.Graphics.FillRectangle(Brushes.Transparent, rc);
			if (imgDriveIcon.Images.Count > 0)
			{
				imgDriveIcon.Draw(e.Graphics, rc.Left, rc.Top, 0);
			}
		}

		// Here we draw the small pie
		private void pnlSmallPie_Paint(object sender, PaintEventArgs e)
		{
			// AntiAlias greatly improves the look of the pie
			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			if (Sweep != 0)
			{
				e.Graphics.FillPie(BlueBrush, SmallRect, 0, Sweep);
				e.Graphics.FillPie(RedBrush, SmallRect, Sweep, FullAngle - Sweep);
			}
			else
			{
				e.Graphics.FillPie(BlueBrush, SmallRect, 0, 360);
			}
		}

		// We need this timer for when rotating the big Pie Chart
		private void tmrAngle_Tick(object sender, EventArgs e)
		{
			// So that the variable doesn't get too big, we reset it each 360 degrees
			if (CurrAngle < 360)
			{
				pnlBigPie.InitialAngle = CurrAngle;
				CurrAngle++;
			}
			else
			{
				CurrAngle = -360;
			}
		}

		private void chkRotate_CheckedChanged(object sender, EventArgs e)
		{
			if (chkRotate.Checked == true)
			{
				// If the "Rotate Pie" checkbox was checked
				tmrAngle.Start();
			}
			else
			{
				// Else stop the timer, and thus the big Pie Chart from rotating
				tmrAngle.Stop();
			}
		}

		private void lnkVolumeName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			// When the title of the drive is clicked, open that drive
			System.Diagnostics.Process.Start(treeDrives.SelectedNode.Name.ToString());
		}

		private void mnuExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void mnuGeekpedia_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("http://www.geekpedia.com");
		}

		private void mnuAbout_Click(object sender, EventArgs e)
		{
			frmAbout = new frmAbout();
			frmAbout.ShowDialog(this);
			frmAbout.Dispose();
		}
	}
}