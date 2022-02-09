namespace WFA.OCR.UserControls
{
	partial class UCClientAboutMe
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCClientAboutMe));
			this.panelClient = new System.Windows.Forms.Panel();
			this.panelTranslate = new System.Windows.Forms.Panel();
			this.PActive1 = new System.Windows.Forms.Panel();
			this.btnAboutMe = new System.Windows.Forms.Button();
			this.panelTitle = new System.Windows.Forms.Panel();
			this.lblActiveTask = new System.Windows.Forms.Label();
			this.panelHome = new System.Windows.Forms.Panel();
			this.btnHome = new System.Windows.Forms.Button();
			this.panelClientTask = new System.Windows.Forms.Panel();
			this.panelClient.SuspendLayout();
			this.panelTranslate.SuspendLayout();
			this.panelTitle.SuspendLayout();
			this.panelHome.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelClient
			// 
			this.panelClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.panelClient.Controls.Add(this.panelTranslate);
			this.panelClient.Controls.Add(this.panelTitle);
			this.panelClient.Controls.Add(this.panelHome);
			this.panelClient.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelClient.Location = new System.Drawing.Point(0, 0);
			this.panelClient.Name = "panelClient";
			this.panelClient.Size = new System.Drawing.Size(256, 560);
			this.panelClient.TabIndex = 1;
			// 
			// panelTranslate
			// 
			this.panelTranslate.Controls.Add(this.PActive1);
			this.panelTranslate.Controls.Add(this.btnAboutMe);
			this.panelTranslate.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTranslate.Location = new System.Drawing.Point(0, 158);
			this.panelTranslate.Name = "panelTranslate";
			this.panelTranslate.Size = new System.Drawing.Size(256, 38);
			this.panelTranslate.TabIndex = 22;
			// 
			// PActive1
			// 
			this.PActive1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
			this.PActive1.Location = new System.Drawing.Point(0, 0);
			this.PActive1.Name = "PActive1";
			this.PActive1.Size = new System.Drawing.Size(6, 35);
			this.PActive1.TabIndex = 15;
			// 
			// btnAboutMe
			// 
			this.btnAboutMe.FlatAppearance.BorderSize = 0;
			this.btnAboutMe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
			this.btnAboutMe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.btnAboutMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAboutMe.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAboutMe.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnAboutMe.Image = ((System.Drawing.Image)(resources.GetObject("btnAboutMe.Image")));
			this.btnAboutMe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAboutMe.Location = new System.Drawing.Point(9, 0);
			this.btnAboutMe.Name = "btnAboutMe";
			this.btnAboutMe.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
			this.btnAboutMe.Size = new System.Drawing.Size(244, 35);
			this.btnAboutMe.TabIndex = 0;
			this.btnAboutMe.Text = "          About Me";
			this.btnAboutMe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAboutMe.UseVisualStyleBackColor = true;
			this.btnAboutMe.Click += new System.EventHandler(this.btnTranslate_Click);
			// 
			// panelTitle
			// 
			this.panelTitle.Controls.Add(this.lblActiveTask);
			this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTitle.Location = new System.Drawing.Point(0, 38);
			this.panelTitle.Name = "panelTitle";
			this.panelTitle.Size = new System.Drawing.Size(256, 120);
			this.panelTitle.TabIndex = 21;
			// 
			// lblActiveTask
			// 
			this.lblActiveTask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lblActiveTask.AutoSize = true;
			this.lblActiveTask.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblActiveTask.ForeColor = System.Drawing.Color.White;
			this.lblActiveTask.Location = new System.Drawing.Point(23, 38);
			this.lblActiveTask.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this.lblActiveTask.Name = "lblActiveTask";
			this.lblActiveTask.Size = new System.Drawing.Size(75, 19);
			this.lblActiveTask.TabIndex = 3;
			this.lblActiveTask.Text = "About Me";
			// 
			// panelHome
			// 
			this.panelHome.Controls.Add(this.btnHome);
			this.panelHome.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelHome.Location = new System.Drawing.Point(0, 0);
			this.panelHome.Name = "panelHome";
			this.panelHome.Size = new System.Drawing.Size(256, 38);
			this.panelHome.TabIndex = 0;
			// 
			// btnHome
			// 
			this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnHome.FlatAppearance.BorderSize = 0;
			this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(151)))), ((int)(((byte)(174)))));
			this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(137)))), ((int)(((byte)(163)))));
			this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnHome.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHome.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
			this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnHome.Location = new System.Drawing.Point(0, 0);
			this.btnHome.Name = "btnHome";
			this.btnHome.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
			this.btnHome.Size = new System.Drawing.Size(256, 35);
			this.btnHome.TabIndex = 20;
			this.btnHome.Text = "          Home";
			this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnHome.UseVisualStyleBackColor = true;
			this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
			// 
			// panelClientTask
			// 
			this.panelClientTask.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelClientTask.Location = new System.Drawing.Point(256, 0);
			this.panelClientTask.Name = "panelClientTask";
			this.panelClientTask.Size = new System.Drawing.Size(644, 560);
			this.panelClientTask.TabIndex = 2;
			// 
			// UCClientAboutMe
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.Controls.Add(this.panelClientTask);
			this.Controls.Add(this.panelClient);
			this.Name = "UCClientAboutMe";
			this.Size = new System.Drawing.Size(900, 560);
			this.Load += new System.EventHandler(this.UCClientAboutMe_Load);
			this.panelClient.ResumeLayout(false);
			this.panelTranslate.ResumeLayout(false);
			this.panelTitle.ResumeLayout(false);
			this.panelTitle.PerformLayout();
			this.panelHome.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelClient;
		private System.Windows.Forms.Button btnHome;
		private System.Windows.Forms.Panel PActive1;
		private System.Windows.Forms.Button btnAboutMe;
		private System.Windows.Forms.Label lblActiveTask;
		private System.Windows.Forms.Panel panelClientTask;
		private System.Windows.Forms.Panel panelHome;
		private System.Windows.Forms.Panel panelTitle;
		private System.Windows.Forms.Panel panelTranslate;
	}
}
