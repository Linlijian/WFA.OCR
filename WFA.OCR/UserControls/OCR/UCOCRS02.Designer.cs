namespace WFA.OCR.UserControls
{
	partial class UCOCRS02
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCOCRS02));
			this.panelItem = new System.Windows.Forms.Panel();
			this.lblDetail = new System.Windows.Forms.Label();
			this.lblDetailDownloadLanguage = new System.Windows.Forms.Label();
			this.ucScrollbar1 = new CustomControls.UCScrollbar();
			this.clb_LanguageList = new System.Windows.Forms.CheckedListBox();
			this.lblDownloadStatus = new System.Windows.Forms.Label();
			this.btnDownloadLanguage = new System.Windows.Forms.Button();
			this.lblToppic = new System.Windows.Forms.Label();
			this.panelItem.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelItem
			// 
			this.panelItem.AutoScroll = true;
			this.panelItem.Controls.Add(this.lblDetail);
			this.panelItem.Controls.Add(this.lblDetailDownloadLanguage);
			this.panelItem.Controls.Add(this.ucScrollbar1);
			this.panelItem.Controls.Add(this.clb_LanguageList);
			this.panelItem.Controls.Add(this.lblDownloadStatus);
			this.panelItem.Controls.Add(this.btnDownloadLanguage);
			this.panelItem.Controls.Add(this.lblToppic);
			this.panelItem.Location = new System.Drawing.Point(0, 0);
			this.panelItem.Name = "panelItem";
			this.panelItem.Size = new System.Drawing.Size(644, 560);
			this.panelItem.TabIndex = 27;
			// 
			// lblDetail
			// 
			this.lblDetail.AutoSize = true;
			this.lblDetail.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDetail.ForeColor = System.Drawing.Color.White;
			this.lblDetail.Location = new System.Drawing.Point(23, 296);
			this.lblDetail.Name = "lblDetail";
			this.lblDetail.Size = new System.Drawing.Size(532, 95);
			this.lblDetail.TabIndex = 39;
			this.lblDetail.Text = resources.GetString("lblDetail.Text");
			// 
			// lblDetailDownloadLanguage
			// 
			this.lblDetailDownloadLanguage.AutoSize = true;
			this.lblDetailDownloadLanguage.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDetailDownloadLanguage.ForeColor = System.Drawing.Color.White;
			this.lblDetailDownloadLanguage.Location = new System.Drawing.Point(23, 54);
			this.lblDetailDownloadLanguage.Name = "lblDetailDownloadLanguage";
			this.lblDetailDownloadLanguage.Size = new System.Drawing.Size(185, 19);
			this.lblDetailDownloadLanguage.TabIndex = 38;
			this.lblDetailDownloadLanguage.Text = "Data Files for Version 4.0";
			// 
			// ucScrollbar1
			// 
			this.ucScrollbar1.ChannelColor = System.Drawing.Color.Black;
			this.ucScrollbar1.DownArrowImage = ((System.Drawing.Image)(resources.GetObject("ucScrollbar1.DownArrowImage")));
			this.ucScrollbar1.LargeChange = 10;
			this.ucScrollbar1.Location = new System.Drawing.Point(292, 85);
			this.ucScrollbar1.Maximum = 100;
			this.ucScrollbar1.Minimum = 0;
			this.ucScrollbar1.MinimumSize = new System.Drawing.Size(15, 92);
			this.ucScrollbar1.Name = "ucScrollbar1";
			this.ucScrollbar1.Size = new System.Drawing.Size(18, 198);
			this.ucScrollbar1.SmallChange = 1;
			this.ucScrollbar1.TabIndex = 36;
			this.ucScrollbar1.ThumbBottomImage = ((System.Drawing.Image)(resources.GetObject("ucScrollbar1.ThumbBottomImage")));
			this.ucScrollbar1.ThumbBottomSpanImage = ((System.Drawing.Image)(resources.GetObject("ucScrollbar1.ThumbBottomSpanImage")));
			this.ucScrollbar1.ThumbMiddleImage = ((System.Drawing.Image)(resources.GetObject("ucScrollbar1.ThumbMiddleImage")));
			this.ucScrollbar1.ThumbTopImage = ((System.Drawing.Image)(resources.GetObject("ucScrollbar1.ThumbTopImage")));
			this.ucScrollbar1.ThumbTopSpanImage = ((System.Drawing.Image)(resources.GetObject("ucScrollbar1.ThumbTopSpanImage")));
			this.ucScrollbar1.UpArrowImage = ((System.Drawing.Image)(resources.GetObject("ucScrollbar1.UpArrowImage")));
			this.ucScrollbar1.Value = 0;
			// 
			// clb_LanguageList
			// 
			this.clb_LanguageList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.clb_LanguageList.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.clb_LanguageList.CheckOnClick = true;
			this.clb_LanguageList.Font = new System.Drawing.Font("Itim", 12F);
			this.clb_LanguageList.ForeColor = System.Drawing.Color.White;
			this.clb_LanguageList.FormattingEnabled = true;
			this.clb_LanguageList.HorizontalScrollbar = true;
			this.clb_LanguageList.Location = new System.Drawing.Point(27, 85);
			this.clb_LanguageList.Name = "clb_LanguageList";
			this.clb_LanguageList.Size = new System.Drawing.Size(283, 198);
			this.clb_LanguageList.TabIndex = 35;
			// 
			// lblDownloadStatus
			// 
			this.lblDownloadStatus.AutoSize = true;
			this.lblDownloadStatus.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDownloadStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
			this.lblDownloadStatus.Location = new System.Drawing.Point(143, 464);
			this.lblDownloadStatus.Name = "lblDownloadStatus";
			this.lblDownloadStatus.Size = new System.Drawing.Size(0, 19);
			this.lblDownloadStatus.TabIndex = 34;
			// 
			// btnDownloadLanguage
			// 
			this.btnDownloadLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.btnDownloadLanguage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.btnDownloadLanguage.FlatAppearance.BorderSize = 2;
			this.btnDownloadLanguage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
			this.btnDownloadLanguage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.btnDownloadLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDownloadLanguage.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDownloadLanguage.ForeColor = System.Drawing.Color.White;
			this.btnDownloadLanguage.Location = new System.Drawing.Point(27, 449);
			this.btnDownloadLanguage.Name = "btnDownloadLanguage";
			this.btnDownloadLanguage.Size = new System.Drawing.Size(110, 34);
			this.btnDownloadLanguage.TabIndex = 33;
			this.btnDownloadLanguage.Text = "Download";
			this.btnDownloadLanguage.UseVisualStyleBackColor = false;
			this.btnDownloadLanguage.Click += new System.EventHandler(this.btnDownloadLanguage_Click);
			// 
			// lblToppic
			// 
			this.lblToppic.AutoSize = true;
			this.lblToppic.Font = new System.Drawing.Font("Itim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblToppic.ForeColor = System.Drawing.Color.White;
			this.lblToppic.Location = new System.Drawing.Point(22, 17);
			this.lblToppic.Name = "lblToppic";
			this.lblToppic.Size = new System.Drawing.Size(194, 25);
			this.lblToppic.TabIndex = 27;
			this.lblToppic.Text = "Download Language";
			// 
			// UCOCRS02
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.Controls.Add(this.panelItem);
			this.Name = "UCOCRS02";
			this.Size = new System.Drawing.Size(644, 560);
			this.Load += new System.EventHandler(this.UCOCRS02_Load);
			this.panelItem.ResumeLayout(false);
			this.panelItem.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panelItem;
		private CustomControls.UCScrollbar ucScrollbar1;
		private System.Windows.Forms.CheckedListBox clb_LanguageList;
		private System.Windows.Forms.Label lblDownloadStatus;
		private System.Windows.Forms.Button btnDownloadLanguage;
		private System.Windows.Forms.Label lblToppic;
		private System.Windows.Forms.Label lblDetailDownloadLanguage;
		private System.Windows.Forms.Label lblDetail;
	}
}
