using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DriveStat
{
	public partial class frmAbout : Form
	{
		public frmAbout()
		{
			InitializeComponent();
		}

		private void lnkGeekpedia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("http://www.geekpedia.com");
		}

		private void picLogo_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("http://www.geekpedia.com");
		}

		private void lnkCredits_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("http://free-zg.htnet.hr/jsribar/en/");
		}
	}
}