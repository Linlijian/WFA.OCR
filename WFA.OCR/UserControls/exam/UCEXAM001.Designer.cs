namespace WFA.OCR.UserControls
{
	partial class UCEXAM001
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
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.lblSortImage = new System.Windows.Forms.Label();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.lblGenerateStatus = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblToppic
			// 
			this.lblToppic.AutoSize = true;
			this.lblToppic.Font = new System.Drawing.Font("Itim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblToppic.ForeColor = System.Drawing.Color.White;
			this.lblToppic.Location = new System.Drawing.Point(22, 17);
			this.lblToppic.Name = "lblToppic";
			this.lblToppic.Size = new System.Drawing.Size(150, 25);
			this.lblToppic.TabIndex = 0;
			this.lblToppic.Text = "Convert to PDF";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(23, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 19);
			this.label1.TabIndex = 1;
			this.label1.Text = "Add Image file";
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
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.Black;
			this.btnDelete.BackgroundImage = global::WFA.PlugIn.Image.ImageResource.subtract_32px;
			this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
			this.btnDelete.FlatAppearance.BorderSize = 2;
			this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
			this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.ForeColor = System.Drawing.Color.Black;
			this.btnDelete.Location = new System.Drawing.Point(69, 73);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(36, 36);
			this.btnDelete.TabIndex = 4;
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.Black;
			this.btnAdd.BackgroundImage = global::WFA.PlugIn.Image.ImageResource.plus_math_32px;
			this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
			this.btnAdd.FlatAppearance.BorderSize = 2;
			this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
			this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.ForeColor = System.Drawing.Color.Black;
			this.btnAdd.Location = new System.Drawing.Point(27, 73);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(36, 36);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
			// UCPDF2IMGF001
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.Controls.Add(this.lblGenerateStatus);
			this.Controls.Add(this.btnGenerate);
			this.Controls.Add(this.lblSortImage);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.listboxImage);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblToppic);
			this.Name = "UCPDF2IMGF001";
			this.Size = new System.Drawing.Size(644, 560);
			this.Load += new System.EventHandler(this.UCPDF2IMGF001_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblToppic;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.OpenFileDialog OFDAddImage;
		private System.Windows.Forms.ListBox listboxImage;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Label lblSortImage;
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.Label lblGenerateStatus;
	}
}
