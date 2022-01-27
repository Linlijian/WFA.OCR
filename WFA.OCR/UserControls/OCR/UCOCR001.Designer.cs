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
			this.label1 = new System.Windows.Forms.Label();
			this.btnStartTranslate = new System.Windows.Forms.Button();
			this.lblProcesssId = new System.Windows.Forms.Label();
			this.ddlProcessId = new System.Windows.Forms.ComboBox();
			this.lblStartStatus = new System.Windows.Forms.Label();
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
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(23, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 19);
			this.label1.TabIndex = 1;
			this.label1.Text = "Process Id";
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
			this.btnStartTranslate.Location = new System.Drawing.Point(28, 128);
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
			this.lblStartStatus.Location = new System.Drawing.Point(144, 143);
			this.lblStartStatus.Name = "lblStartStatus";
			this.lblStartStatus.Size = new System.Drawing.Size(0, 19);
			this.lblStartStatus.TabIndex = 13;
			// 
			// UCOCR001
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.Controls.Add(this.lblStartStatus);
			this.Controls.Add(this.ddlProcessId);
			this.Controls.Add(this.lblProcesssId);
			this.Controls.Add(this.btnStartTranslate);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblToppic);
			this.Name = "UCOCR001";
			this.Size = new System.Drawing.Size(644, 560);
			this.Load += new System.EventHandler(this.UCOCR001_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblToppic;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnStartTranslate;
		private System.Windows.Forms.Label lblProcesssId;
		private System.Windows.Forms.ComboBox ddlProcessId;
		private System.Windows.Forms.Label lblStartStatus;
	}
}
