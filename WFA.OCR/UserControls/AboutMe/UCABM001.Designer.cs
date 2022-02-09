namespace WFA.OCR.UserControls
{
	partial class UCABM001
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCABM001));
			this.panelItem = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pbProfileImage = new System.Windows.Forms.PictureBox();
			this.lblDetail = new System.Windows.Forms.Label();
			this.lblToppic = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panelItem.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbProfileImage)).BeginInit();
			this.SuspendLayout();
			// 
			// panelItem
			// 
			this.panelItem.AutoScroll = true;
			this.panelItem.Controls.Add(this.label3);
			this.panelItem.Controls.Add(this.label2);
			this.panelItem.Controls.Add(this.label1);
			this.panelItem.Controls.Add(this.pbProfileImage);
			this.panelItem.Controls.Add(this.lblDetail);
			this.panelItem.Controls.Add(this.lblToppic);
			this.panelItem.Location = new System.Drawing.Point(0, 0);
			this.panelItem.Name = "panelItem";
			this.panelItem.Size = new System.Drawing.Size(644, 560);
			this.panelItem.TabIndex = 27;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Itim", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.label2.Location = new System.Drawing.Point(24, 342);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(213, 27);
			this.label2.TabIndex = 42;
			this.label2.Text = "Software Engineering";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Itim", 22F);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(23, 307);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(119, 35);
			this.label1.TabIndex = 41;
			this.label1.Text = "Linlijian";
			// 
			// pbProfileImage
			// 
			this.pbProfileImage.Location = new System.Drawing.Point(27, 56);
			this.pbProfileImage.Name = "pbProfileImage";
			this.pbProfileImage.Size = new System.Drawing.Size(248, 248);
			this.pbProfileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbProfileImage.TabIndex = 40;
			this.pbProfileImage.TabStop = false;
			// 
			// lblDetail
			// 
			this.lblDetail.AutoSize = true;
			this.lblDetail.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDetail.ForeColor = System.Drawing.Color.White;
			this.lblDetail.Location = new System.Drawing.Point(25, 395);
			this.lblDetail.Name = "lblDetail";
			this.lblDetail.Size = new System.Drawing.Size(590, 76);
			this.lblDetail.TabIndex = 39;
			this.lblDetail.Text = resources.GetString("lblDetail.Text");
			// 
			// lblToppic
			// 
			this.lblToppic.AutoSize = true;
			this.lblToppic.Font = new System.Drawing.Font("Itim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblToppic.ForeColor = System.Drawing.Color.White;
			this.lblToppic.Location = new System.Drawing.Point(22, 17);
			this.lblToppic.Name = "lblToppic";
			this.lblToppic.Size = new System.Drawing.Size(98, 25);
			this.lblToppic.TabIndex = 27;
			this.lblToppic.Text = "About Me";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Itim", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Red;
			this.label3.Location = new System.Drawing.Point(25, 504);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(584, 23);
			this.label3.TabIndex = 43;
			this.label3.Text = "If you believe the program is unreliable, you are not compelled to use it.";
			// 
			// UCABM001
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.Controls.Add(this.panelItem);
			this.Name = "UCABM001";
			this.Size = new System.Drawing.Size(644, 560);
			this.Load += new System.EventHandler(this.UCABM001_Load);
			this.panelItem.ResumeLayout(false);
			this.panelItem.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbProfileImage)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panelItem;
		private System.Windows.Forms.Label lblToppic;
		private System.Windows.Forms.Label lblDetail;
		private System.Windows.Forms.PictureBox pbProfileImage;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
	}
}
