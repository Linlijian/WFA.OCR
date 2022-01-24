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
			this.OFDAddImage = new System.Windows.Forms.OpenFileDialog();
			this.listboxImage = new System.Windows.Forms.ListBox();
			this.lblSortImage = new System.Windows.Forms.Label();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.lblGenerateStatus = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
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
			// OFDAddImage
			// 
			this.OFDAddImage.FileName = "OFDAddImage";
			// 
			// listboxImage
			// 
			this.listboxImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.listboxImage.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listboxImage.Font = new System.Drawing.Font("Itim", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listboxImage.ForeColor = System.Drawing.Color.White;
			this.listboxImage.FormattingEnabled = true;
			this.listboxImage.ItemHeight = 15;
			this.listboxImage.Location = new System.Drawing.Point(27, 115);
			this.listboxImage.Name = "listboxImage";
			this.listboxImage.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.listboxImage.Size = new System.Drawing.Size(417, 165);
			this.listboxImage.TabIndex = 3;
			// 
			// lblSortImage
			// 
			this.lblSortImage.AutoSize = true;
			this.lblSortImage.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSortImage.ForeColor = System.Drawing.Color.White;
			this.lblSortImage.Location = new System.Drawing.Point(24, 296);
			this.lblSortImage.Name = "lblSortImage";
			this.lblSortImage.Size = new System.Drawing.Size(292, 19);
			this.lblSortImage.TabIndex = 6;
			this.lblSortImage.Text = "Sorting file name  before converet to pdf.";
			// 
			// btnGenerate
			// 
			this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.btnGenerate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.btnGenerate.FlatAppearance.BorderSize = 2;
			this.btnGenerate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
			this.btnGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGenerate.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGenerate.ForeColor = System.Drawing.Color.White;
			this.btnGenerate.Location = new System.Drawing.Point(28, 353);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(110, 34);
			this.btnGenerate.TabIndex = 10;
			this.btnGenerate.Text = "Generate";
			this.btnGenerate.UseVisualStyleBackColor = false;
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// lblGenerateStatus
			// 
			this.lblGenerateStatus.AutoSize = true;
			this.lblGenerateStatus.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGenerateStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
			this.lblGenerateStatus.Location = new System.Drawing.Point(144, 368);
			this.lblGenerateStatus.Name = "lblGenerateStatus";
			this.lblGenerateStatus.Size = new System.Drawing.Size(0, 19);
			this.lblGenerateStatus.TabIndex = 11;
			// 
			// comboBox1
			// 
			this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
			this.comboBox1.Cursor = System.Windows.Forms.Cursors.Default;
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Font = new System.Drawing.Font("Itim", 12F);
			this.comboBox1.ForeColor = System.Drawing.Color.White;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(27, 73);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(289, 27);
			this.comboBox1.TabIndex = 12;
			// 
			// UCOCR001
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.lblGenerateStatus);
			this.Controls.Add(this.btnGenerate);
			this.Controls.Add(this.lblSortImage);
			this.Controls.Add(this.listboxImage);
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
		private System.Windows.Forms.OpenFileDialog OFDAddImage;
		private System.Windows.Forms.ListBox listboxImage;
		private System.Windows.Forms.Label lblSortImage;
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.Label lblGenerateStatus;
		private System.Windows.Forms.ComboBox comboBox1;
	}
}
