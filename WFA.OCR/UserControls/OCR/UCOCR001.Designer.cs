namespace WFA.OCR.UserControls
{
	partial class UCOCR001
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCOCR001));
			this.panelItem = new System.Windows.Forms.Panel();
			this.lblTemp = new System.Windows.Forms.Label();
			this.lblDetail = new System.Windows.Forms.Label();
			this.ddlTargetLanguage = new System.Windows.Forms.ComboBox();
			this.lblTargetLanguage = new System.Windows.Forms.Label();
			this.ddlSourceLanguage = new System.Windows.Forms.ComboBox();
			this.lblSourceLanguage = new System.Windows.Forms.Label();
			this.lblSaveStatus = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.lblHotkey = new System.Windows.Forms.Label();
			this.lblDetailDownloadLanguage = new System.Windows.Forms.Label();
			this.ucScrollbar1 = new CustomControls.UCScrollbar();
			this.clb_LanguageList = new System.Windows.Forms.CheckedListBox();
			this.lblDownloadStatus = new System.Windows.Forms.Label();
			this.btnDownloadLanguage = new System.Windows.Forms.Button();
			this.lblDownloadLanguage = new System.Windows.Forms.Label();
			this.ddlHotkey = new System.Windows.Forms.ComboBox();
			this.lblToppic = new System.Windows.Forms.Label();
			this.ucScrollbar2 = new CustomControls.UCScrollbar();
			this.panelItem.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelItem
			// 
			this.panelItem.AutoScroll = true;
			this.panelItem.Controls.Add(this.lblTemp);
			this.panelItem.Controls.Add(this.lblDetail);
			this.panelItem.Controls.Add(this.ddlTargetLanguage);
			this.panelItem.Controls.Add(this.lblTargetLanguage);
			this.panelItem.Controls.Add(this.ddlSourceLanguage);
			this.panelItem.Controls.Add(this.lblSourceLanguage);
			this.panelItem.Controls.Add(this.lblSaveStatus);
			this.panelItem.Controls.Add(this.btnSave);
			this.panelItem.Controls.Add(this.lblHotkey);
			this.panelItem.Controls.Add(this.lblDetailDownloadLanguage);
			this.panelItem.Controls.Add(this.ucScrollbar1);
			this.panelItem.Controls.Add(this.clb_LanguageList);
			this.panelItem.Controls.Add(this.lblDownloadStatus);
			this.panelItem.Controls.Add(this.btnDownloadLanguage);
			this.panelItem.Controls.Add(this.lblDownloadLanguage);
			this.panelItem.Controls.Add(this.ddlHotkey);
			this.panelItem.Controls.Add(this.lblToppic);
			this.panelItem.Location = new System.Drawing.Point(0, 0);
			this.panelItem.Name = "panelItem";
			this.panelItem.Size = new System.Drawing.Size(644, 560);
			this.panelItem.TabIndex = 27;
			// 
			// lblTemp
			// 
			this.lblTemp.AutoSize = true;
			this.lblTemp.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTemp.ForeColor = System.Drawing.Color.Black;
			this.lblTemp.Location = new System.Drawing.Point(300, 702);
			this.lblTemp.Name = "lblTemp";
			this.lblTemp.Size = new System.Drawing.Size(299, 133);
			this.lblTemp.TabIndex = 46;
			this.lblTemp.Text = "For translation, at least two languages mu\r\n\r\n\r\n\r\n\r\n\r\nst be downloaded.";
			// 
			// lblDetail
			// 
			this.lblDetail.AutoSize = true;
			this.lblDetail.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDetail.ForeColor = System.Drawing.Color.White;
			this.lblDetail.Location = new System.Drawing.Point(27, 277);
			this.lblDetail.Name = "lblDetail";
			this.lblDetail.Size = new System.Drawing.Size(496, 38);
			this.lblDetail.TabIndex = 45;
			this.lblDetail.Text = "You haven\'t downloaded the language if you can\'t select the source or \r\ntarget la" +
    "nguage. kindly make a download.";
			// 
			// ddlTargetLanguage
			// 
			this.ddlTargetLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.ddlTargetLanguage.Cursor = System.Windows.Forms.Cursors.Default;
			this.ddlTargetLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ddlTargetLanguage.Font = new System.Drawing.Font("Itim", 12F);
			this.ddlTargetLanguage.ForeColor = System.Drawing.Color.White;
			this.ddlTargetLanguage.FormattingEnabled = true;
			this.ddlTargetLanguage.Location = new System.Drawing.Point(27, 153);
			this.ddlTargetLanguage.Name = "ddlTargetLanguage";
			this.ddlTargetLanguage.Size = new System.Drawing.Size(290, 27);
			this.ddlTargetLanguage.TabIndex = 44;
			// 
			// lblTargetLanguage
			// 
			this.lblTargetLanguage.AutoSize = true;
			this.lblTargetLanguage.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTargetLanguage.ForeColor = System.Drawing.Color.White;
			this.lblTargetLanguage.Location = new System.Drawing.Point(23, 202);
			this.lblTargetLanguage.Name = "lblTargetLanguage";
			this.lblTargetLanguage.Size = new System.Drawing.Size(165, 19);
			this.lblTargetLanguage.TabIndex = 43;
			this.lblTargetLanguage.Text = "Select target language";
			// 
			// ddlSourceLanguage
			// 
			this.ddlSourceLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.ddlSourceLanguage.Cursor = System.Windows.Forms.Cursors.Default;
			this.ddlSourceLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ddlSourceLanguage.Font = new System.Drawing.Font("Itim", 12F);
			this.ddlSourceLanguage.ForeColor = System.Drawing.Color.White;
			this.ddlSourceLanguage.FormattingEnabled = true;
			this.ddlSourceLanguage.Location = new System.Drawing.Point(27, 224);
			this.ddlSourceLanguage.Name = "ddlSourceLanguage";
			this.ddlSourceLanguage.Size = new System.Drawing.Size(290, 27);
			this.ddlSourceLanguage.TabIndex = 42;
			// 
			// lblSourceLanguage
			// 
			this.lblSourceLanguage.AutoSize = true;
			this.lblSourceLanguage.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSourceLanguage.ForeColor = System.Drawing.Color.White;
			this.lblSourceLanguage.Location = new System.Drawing.Point(23, 131);
			this.lblSourceLanguage.Name = "lblSourceLanguage";
			this.lblSourceLanguage.Size = new System.Drawing.Size(169, 19);
			this.lblSourceLanguage.TabIndex = 41;
			this.lblSourceLanguage.Text = "Select source language";
			// 
			// lblSaveStatus
			// 
			this.lblSaveStatus.AutoSize = true;
			this.lblSaveStatus.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSaveStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
			this.lblSaveStatus.Location = new System.Drawing.Point(143, 343);
			this.lblSaveStatus.Name = "lblSaveStatus";
			this.lblSaveStatus.Size = new System.Drawing.Size(0, 19);
			this.lblSaveStatus.TabIndex = 40;
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.btnSave.FlatAppearance.BorderSize = 2;
			this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
			this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.Location = new System.Drawing.Point(27, 328);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(110, 34);
			this.btnSave.TabIndex = 39;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// lblHotkey
			// 
			this.lblHotkey.AutoSize = true;
			this.lblHotkey.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHotkey.ForeColor = System.Drawing.Color.White;
			this.lblHotkey.Location = new System.Drawing.Point(23, 54);
			this.lblHotkey.Name = "lblHotkey";
			this.lblHotkey.Size = new System.Drawing.Size(274, 19);
			this.lblHotkey.TabIndex = 38;
			this.lblHotkey.Text = "To capture on screen, choose a hotkey.";
			// 
			// lblDetailDownloadLanguage
			// 
			this.lblDetailDownloadLanguage.AutoSize = true;
			this.lblDetailDownloadLanguage.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDetailDownloadLanguage.ForeColor = System.Drawing.Color.White;
			this.lblDetailDownloadLanguage.Location = new System.Drawing.Point(23, 450);
			this.lblDetailDownloadLanguage.Name = "lblDetailDownloadLanguage";
			this.lblDetailDownloadLanguage.Size = new System.Drawing.Size(424, 19);
			this.lblDetailDownloadLanguage.TabIndex = 37;
			this.lblDetailDownloadLanguage.Text = "For translation, at least two languages must be downloaded.";
			// 
			// ucScrollbar1
			// 
			this.ucScrollbar1.ChannelColor = System.Drawing.Color.Black;
			this.ucScrollbar1.DownArrowImage = ((System.Drawing.Image)(resources.GetObject("ucScrollbar1.DownArrowImage")));
			this.ucScrollbar1.LargeChange = 10;
			this.ucScrollbar1.Location = new System.Drawing.Point(292, 481);
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
			this.clb_LanguageList.Location = new System.Drawing.Point(27, 481);
			this.clb_LanguageList.Name = "clb_LanguageList";
			this.clb_LanguageList.Size = new System.Drawing.Size(283, 198);
			this.clb_LanguageList.TabIndex = 35;
			// 
			// lblDownloadStatus
			// 
			this.lblDownloadStatus.AutoSize = true;
			this.lblDownloadStatus.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDownloadStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
			this.lblDownloadStatus.Location = new System.Drawing.Point(143, 709);
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
			this.btnDownloadLanguage.Location = new System.Drawing.Point(27, 694);
			this.btnDownloadLanguage.Name = "btnDownloadLanguage";
			this.btnDownloadLanguage.Size = new System.Drawing.Size(110, 34);
			this.btnDownloadLanguage.TabIndex = 33;
			this.btnDownloadLanguage.Text = "Download";
			this.btnDownloadLanguage.UseVisualStyleBackColor = false;
			this.btnDownloadLanguage.Click += new System.EventHandler(this.btnDownloadLanguage_Click);
			// 
			// lblDownloadLanguage
			// 
			this.lblDownloadLanguage.AutoSize = true;
			this.lblDownloadLanguage.Font = new System.Drawing.Font("Itim", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDownloadLanguage.ForeColor = System.Drawing.Color.White;
			this.lblDownloadLanguage.Location = new System.Drawing.Point(23, 410);
			this.lblDownloadLanguage.Name = "lblDownloadLanguage";
			this.lblDownloadLanguage.Size = new System.Drawing.Size(174, 23);
			this.lblDownloadLanguage.TabIndex = 32;
			this.lblDownloadLanguage.Text = "Download Language";
			// 
			// ddlHotkey
			// 
			this.ddlHotkey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.ddlHotkey.Cursor = System.Windows.Forms.Cursors.Default;
			this.ddlHotkey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ddlHotkey.Font = new System.Drawing.Font("Itim", 12F);
			this.ddlHotkey.ForeColor = System.Drawing.Color.White;
			this.ddlHotkey.FormattingEnabled = true;
			this.ddlHotkey.Location = new System.Drawing.Point(27, 80);
			this.ddlHotkey.Name = "ddlHotkey";
			this.ddlHotkey.Size = new System.Drawing.Size(290, 27);
			this.ddlHotkey.TabIndex = 30;
			this.ddlHotkey.SelectionChangeCommitted += new System.EventHandler(this.ddlHotkey_SelectionChangeCommitted);
			// 
			// lblToppic
			// 
			this.lblToppic.AutoSize = true;
			this.lblToppic.Font = new System.Drawing.Font("Itim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblToppic.ForeColor = System.Drawing.Color.White;
			this.lblToppic.Location = new System.Drawing.Point(22, 17);
			this.lblToppic.Name = "lblToppic";
			this.lblToppic.Size = new System.Drawing.Size(180, 25);
			this.lblToppic.TabIndex = 27;
			this.lblToppic.Text = "Translation Screen";
			// 
			// ucScrollbar2
			// 
			this.ucScrollbar2.ChannelColor = System.Drawing.Color.Black;
			this.ucScrollbar2.DownArrowImage = ((System.Drawing.Image)(resources.GetObject("ucScrollbar2.DownArrowImage")));
			this.ucScrollbar2.LargeChange = 10;
			this.ucScrollbar2.Location = new System.Drawing.Point(623, 0);
			this.ucScrollbar2.Maximum = 100;
			this.ucScrollbar2.Minimum = 0;
			this.ucScrollbar2.MinimumSize = new System.Drawing.Size(15, 92);
			this.ucScrollbar2.Name = "ucScrollbar2";
			this.ucScrollbar2.Size = new System.Drawing.Size(21, 560);
			this.ucScrollbar2.SmallChange = 1;
			this.ucScrollbar2.TabIndex = 38;
			this.ucScrollbar2.ThumbBottomImage = ((System.Drawing.Image)(resources.GetObject("ucScrollbar2.ThumbBottomImage")));
			this.ucScrollbar2.ThumbBottomSpanImage = ((System.Drawing.Image)(resources.GetObject("ucScrollbar2.ThumbBottomSpanImage")));
			this.ucScrollbar2.ThumbMiddleImage = ((System.Drawing.Image)(resources.GetObject("ucScrollbar2.ThumbMiddleImage")));
			this.ucScrollbar2.ThumbTopImage = ((System.Drawing.Image)(resources.GetObject("ucScrollbar2.ThumbTopImage")));
			this.ucScrollbar2.ThumbTopSpanImage = ((System.Drawing.Image)(resources.GetObject("ucScrollbar2.ThumbTopSpanImage")));
			this.ucScrollbar2.UpArrowImage = ((System.Drawing.Image)(resources.GetObject("ucScrollbar2.UpArrowImage")));
			this.ucScrollbar2.Value = 0;
			// 
			// UCOCR001
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.Controls.Add(this.ucScrollbar2);
			this.Controls.Add(this.panelItem);
			this.Name = "UCOCR001";
			this.Size = new System.Drawing.Size(644, 560);
			this.Load += new System.EventHandler(this.UCOCR001_Load);
			this.panelItem.ResumeLayout(false);
			this.panelItem.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panelItem;
		private System.Windows.Forms.Label lblDetailDownloadLanguage;
		private CustomControls.UCScrollbar ucScrollbar1;
		private System.Windows.Forms.CheckedListBox clb_LanguageList;
		private System.Windows.Forms.Label lblDownloadStatus;
		private System.Windows.Forms.Button btnDownloadLanguage;
		private System.Windows.Forms.Label lblDownloadLanguage;
		private System.Windows.Forms.ComboBox ddlHotkey;
		private System.Windows.Forms.Label lblToppic;
		private CustomControls.UCScrollbar ucScrollbar2;
		private System.Windows.Forms.Label lblSaveStatus;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label lblHotkey;
		private System.Windows.Forms.ComboBox ddlTargetLanguage;
		private System.Windows.Forms.Label lblTargetLanguage;
		private System.Windows.Forms.ComboBox ddlSourceLanguage;
		private System.Windows.Forms.Label lblSourceLanguage;
		private System.Windows.Forms.Label lblDetail;
		private System.Windows.Forms.Label lblTemp;
	}
}
