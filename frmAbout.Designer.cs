namespace DriveStat
{
	partial class frmAbout
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
			this.picLogo = new System.Windows.Forms.PictureBox();
			this.lblCopyright1 = new System.Windows.Forms.Label();
			this.lblCredits = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.lnkGeekpedia = new System.Windows.Forms.LinkLabel();
			this.lnkCredits = new System.Windows.Forms.LinkLabel();
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// picLogo
			// 
			this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
			this.picLogo.Location = new System.Drawing.Point(0, 1);
			this.picLogo.Name = "picLogo";
			this.picLogo.Size = new System.Drawing.Size(400, 78);
			this.picLogo.TabIndex = 0;
			this.picLogo.TabStop = false;
			this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
			// 
			// lblCopyright1
			// 
			this.lblCopyright1.AutoSize = true;
			this.lblCopyright1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCopyright1.Location = new System.Drawing.Point(12, 112);
			this.lblCopyright1.Name = "lblCopyright1";
			this.lblCopyright1.Size = new System.Drawing.Size(241, 13);
			this.lblCopyright1.TabIndex = 1;
			this.lblCopyright1.Text = "Copyright © Geekpedia.com 2004 - 2005";
			// 
			// lblCredits
			// 
			this.lblCredits.AutoSize = true;
			this.lblCredits.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCredits.Location = new System.Drawing.Point(12, 130);
			this.lblCredits.Name = "lblCredits";
			this.lblCredits.Size = new System.Drawing.Size(194, 13);
			this.lblCredits.TabIndex = 2;
			this.lblCredits.Text = "Credits for the 3D Pie chart go to";
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.Location = new System.Drawing.Point(13, 94);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(182, 13);
			this.lblName.TabIndex = 3;
			this.lblName.Text = "Geekpedia DriveStat v0.1 Beta";
			// 
			// lnkGeekpedia
			// 
			this.lnkGeekpedia.AutoSize = true;
			this.lnkGeekpedia.Location = new System.Drawing.Point(254, 164);
			this.lnkGeekpedia.Name = "lnkGeekpedia";
			this.lnkGeekpedia.Size = new System.Drawing.Size(134, 13);
			this.lnkGeekpedia.TabIndex = 4;
			this.lnkGeekpedia.TabStop = true;
			this.lnkGeekpedia.Text = "http://www.geekpedia.com";
			this.lnkGeekpedia.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGeekpedia_LinkClicked);
			// 
			// lnkCredits
			// 
			this.lnkCredits.AutoSize = true;
			this.lnkCredits.Location = new System.Drawing.Point(208, 130);
			this.lnkCredits.Name = "lnkCredits";
			this.lnkCredits.Size = new System.Drawing.Size(62, 13);
			this.lnkCredits.TabIndex = 5;
			this.lnkCredits.TabStop = true;
			this.lnkCredits.Text = "Julijan Sribar";
			this.lnkCredits.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCredits_LinkClicked);
			// 
			// frmAbout
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(400, 186);
			this.Controls.Add(this.lnkCredits);
			this.Controls.Add(this.lnkGeekpedia);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.lblCredits);
			this.Controls.Add(this.lblCopyright1);
			this.Controls.Add(this.picLogo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmAbout";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "About DriveStat";
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox picLogo;
		private System.Windows.Forms.Label lblCopyright1;
		private System.Windows.Forms.Label lblCredits;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.LinkLabel lnkGeekpedia;
		private System.Windows.Forms.LinkLabel lnkCredits;

	}
}