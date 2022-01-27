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
			this.lblToppic = new System.Windows.Forms.Label();
			this.lblDropdownlist = new System.Windows.Forms.Label();
			this.btnStartTranslate = new System.Windows.Forms.Button();
			this.lblProcesssId = new System.Windows.Forms.Label();
			this.ddlProcessId = new System.Windows.Forms.ComboBox();
			this.lblStartStatus = new System.Windows.Forms.Label();
			this.lblRebuildDDL = new System.Windows.Forms.Label();
			this.btnReload = new System.Windows.Forms.Button();
			this.lblRebuildDDLDetail = new System.Windows.Forms.Label();
			this.lblExitOverly = new System.Windows.Forms.Label();
			this.lblExitOverlyDetail = new System.Windows.Forms.Label();
			this.btnExitOverly = new System.Windows.Forms.Button();
			this.lblReloadStatus = new System.Windows.Forms.Label();
			this.lblExitOverlyStatus = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblToppic
			// 
			this.lblToppic.AutoSize = true;
			this.lblToppic.Font = new System.Drawing.Font("Itim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblToppic.ForeColor = System.Drawing.Color.White;
			this.lblToppic.Location = new System.Drawing.Point(22, 17);
			this.lblToppic.Name = "lblToppic";
			this.lblToppic.Size = new System.Drawing.Size(180, 25);
			this.lblToppic.TabIndex = 0;
			this.lblToppic.Text = "Translation Screen";
			// 
			// lblDropdownlist
			// 
			this.lblDropdownlist.AutoSize = true;
			this.lblDropdownlist.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDropdownlist.ForeColor = System.Drawing.Color.White;
			this.lblDropdownlist.Location = new System.Drawing.Point(23, 51);
			this.lblDropdownlist.Name = "lblDropdownlist";
			this.lblDropdownlist.Size = new System.Drawing.Size(80, 19);
			this.lblDropdownlist.TabIndex = 1;
			this.lblDropdownlist.Text = "Process Id";
			// 
			// btnStartTranslate
			// 
			this.btnStartTranslate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.btnStartTranslate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.btnStartTranslate.FlatAppearance.BorderSize = 2;
			this.btnStartTranslate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
			this.btnStartTranslate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.btnStartTranslate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnStartTranslate.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStartTranslate.ForeColor = System.Drawing.Color.White;
			this.btnStartTranslate.Location = new System.Drawing.Point(27, 105);
			this.btnStartTranslate.Name = "btnStartTranslate";
			this.btnStartTranslate.Size = new System.Drawing.Size(110, 34);
			this.btnStartTranslate.TabIndex = 10;
			this.btnStartTranslate.Text = "Start";
			this.btnStartTranslate.UseVisualStyleBackColor = false;
			this.btnStartTranslate.Click += new System.EventHandler(this.btnStartTranslate_Click);
			// 
			// lblProcesssId
			// 
			this.lblProcesssId.AutoSize = true;
			this.lblProcesssId.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProcesssId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
			this.lblProcesssId.Location = new System.Drawing.Point(324, 80);
			this.lblProcesssId.Name = "lblProcesssId";
			this.lblProcesssId.Size = new System.Drawing.Size(0, 19);
			this.lblProcesssId.TabIndex = 11;
			// 
			// ddlProcessId
			// 
			this.ddlProcessId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.ddlProcessId.Cursor = System.Windows.Forms.Cursors.Default;
			this.ddlProcessId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ddlProcessId.Font = new System.Drawing.Font("Itim", 12F);
			this.ddlProcessId.ForeColor = System.Drawing.Color.White;
			this.ddlProcessId.FormattingEnabled = true;
			this.ddlProcessId.Location = new System.Drawing.Point(28, 72);
			this.ddlProcessId.Name = "ddlProcessId";
			this.ddlProcessId.Size = new System.Drawing.Size(290, 27);
			this.ddlProcessId.TabIndex = 12;
			this.ddlProcessId.SelectedIndexChanged += new System.EventHandler(this.ddlProcessId_SelectedIndexChanged);
			// 
			// lblStartStatus
			// 
			this.lblStartStatus.AutoSize = true;
			this.lblStartStatus.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStartStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
			this.lblStartStatus.Location = new System.Drawing.Point(143, 120);
			this.lblStartStatus.Name = "lblStartStatus";
			this.lblStartStatus.Size = new System.Drawing.Size(0, 19);
			this.lblStartStatus.TabIndex = 13;
			// 
			// lblRebuildDDL
			// 
			this.lblRebuildDDL.AutoSize = true;
			this.lblRebuildDDL.Font = new System.Drawing.Font("Itim", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRebuildDDL.ForeColor = System.Drawing.Color.White;
			this.lblRebuildDDL.Location = new System.Drawing.Point(24, 183);
			this.lblRebuildDDL.Name = "lblRebuildDDL";
			this.lblRebuildDDL.Size = new System.Drawing.Size(151, 23);
			this.lblRebuildDDL.TabIndex = 14;
			this.lblRebuildDDL.Text = "Reload process id";
			// 
			// btnReload
			// 
			this.btnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.btnReload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.btnReload.FlatAppearance.BorderSize = 2;
			this.btnReload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
			this.btnReload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReload.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReload.ForeColor = System.Drawing.Color.White;
			this.btnReload.Location = new System.Drawing.Point(27, 239);
			this.btnReload.Name = "btnReload";
			this.btnReload.Size = new System.Drawing.Size(110, 34);
			this.btnReload.TabIndex = 15;
			this.btnReload.Text = "Reload";
			this.btnReload.UseVisualStyleBackColor = false;
			this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
			// 
			// lblRebuildDDLDetail
			// 
			this.lblRebuildDDLDetail.AutoSize = true;
			this.lblRebuildDDLDetail.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRebuildDDLDetail.ForeColor = System.Drawing.Color.White;
			this.lblRebuildDDLDetail.Location = new System.Drawing.Point(24, 217);
			this.lblRebuildDDLDetail.Name = "lblRebuildDDLDetail";
			this.lblRebuildDDLDetail.Size = new System.Drawing.Size(363, 19);
			this.lblRebuildDDLDetail.TabIndex = 16;
			this.lblRebuildDDLDetail.Text = "Reload is used to search for process id to translate.";
			// 
			// lblExitOverly
			// 
			this.lblExitOverly.AutoSize = true;
			this.lblExitOverly.Font = new System.Drawing.Font("Itim", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblExitOverly.ForeColor = System.Drawing.Color.White;
			this.lblExitOverly.Location = new System.Drawing.Point(24, 320);
			this.lblExitOverly.Name = "lblExitOverly";
			this.lblExitOverly.Size = new System.Drawing.Size(99, 23);
			this.lblExitOverly.TabIndex = 17;
			this.lblExitOverly.Text = "Exit Overly";
			// 
			// lblExitOverlyDetail
			// 
			this.lblExitOverlyDetail.AutoSize = true;
			this.lblExitOverlyDetail.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblExitOverlyDetail.ForeColor = System.Drawing.Color.White;
			this.lblExitOverlyDetail.Location = new System.Drawing.Point(24, 353);
			this.lblExitOverlyDetail.Name = "lblExitOverlyDetail";
			this.lblExitOverlyDetail.Size = new System.Drawing.Size(451, 38);
			this.lblExitOverlyDetail.TabIndex = 18;
			this.lblExitOverlyDetail.Text = "If you move the screen of the program you want to translate, \r\nthe Overlay progra" +
    "m will not follow. Press it out and start again.";
			// 
			// btnExitOverly
			// 
			this.btnExitOverly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.btnExitOverly.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.btnExitOverly.FlatAppearance.BorderSize = 2;
			this.btnExitOverly.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
			this.btnExitOverly.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.btnExitOverly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExitOverly.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExitOverly.ForeColor = System.Drawing.Color.White;
			this.btnExitOverly.Location = new System.Drawing.Point(27, 394);
			this.btnExitOverly.Name = "btnExitOverly";
			this.btnExitOverly.Size = new System.Drawing.Size(110, 34);
			this.btnExitOverly.TabIndex = 19;
			this.btnExitOverly.Text = "Exit Overly";
			this.btnExitOverly.UseVisualStyleBackColor = false;
			this.btnExitOverly.Click += new System.EventHandler(this.btnExitOverly_Click);
			// 
			// lblReloadStatus
			// 
			this.lblReloadStatus.AutoSize = true;
			this.lblReloadStatus.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblReloadStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
			this.lblReloadStatus.Location = new System.Drawing.Point(143, 254);
			this.lblReloadStatus.Name = "lblReloadStatus";
			this.lblReloadStatus.Size = new System.Drawing.Size(0, 19);
			this.lblReloadStatus.TabIndex = 20;
			// 
			// lblExitOverlyStatus
			// 
			this.lblExitOverlyStatus.AutoSize = true;
			this.lblExitOverlyStatus.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblExitOverlyStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
			this.lblExitOverlyStatus.Location = new System.Drawing.Point(143, 409);
			this.lblExitOverlyStatus.Name = "lblExitOverlyStatus";
			this.lblExitOverlyStatus.Size = new System.Drawing.Size(0, 19);
			this.lblExitOverlyStatus.TabIndex = 21;
			// 
			// UCOCR001
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.Controls.Add(this.lblExitOverlyStatus);
			this.Controls.Add(this.lblReloadStatus);
			this.Controls.Add(this.btnExitOverly);
			this.Controls.Add(this.lblExitOverlyDetail);
			this.Controls.Add(this.lblExitOverly);
			this.Controls.Add(this.lblRebuildDDLDetail);
			this.Controls.Add(this.btnReload);
			this.Controls.Add(this.lblRebuildDDL);
			this.Controls.Add(this.lblStartStatus);
			this.Controls.Add(this.ddlProcessId);
			this.Controls.Add(this.lblProcesssId);
			this.Controls.Add(this.btnStartTranslate);
			this.Controls.Add(this.lblDropdownlist);
			this.Controls.Add(this.lblToppic);
			this.Name = "UCOCR001";
			this.Size = new System.Drawing.Size(644, 560);
			this.Load += new System.EventHandler(this.UCOCR001_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblToppic;
		private System.Windows.Forms.Label lblDropdownlist;
		private System.Windows.Forms.Button btnStartTranslate;
		private System.Windows.Forms.Label lblProcesssId;
		private System.Windows.Forms.ComboBox ddlProcessId;
		private System.Windows.Forms.Label lblStartStatus;
		private System.Windows.Forms.Label lblRebuildDDL;
		private System.Windows.Forms.Button btnReload;
		private System.Windows.Forms.Label lblRebuildDDLDetail;
		private System.Windows.Forms.Label lblExitOverly;
		private System.Windows.Forms.Label lblExitOverlyDetail;
		private System.Windows.Forms.Button btnExitOverly;
		private System.Windows.Forms.Label lblReloadStatus;
		private System.Windows.Forms.Label lblExitOverlyStatus;
	}
}
