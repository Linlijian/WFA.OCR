namespace WFA.AutoUpdater
{
	partial class NewsForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewsForm));
			this.panelTop = new System.Windows.Forms.Panel();
			this.panelTitle = new System.Windows.Forms.Panel();
			this.lblPanelTitle = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.ucScrollbar1 = new CustomControls.UCScrollbar();
			this.panelTop.SuspendLayout();
			this.panelTitle.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelTop
			// 
			this.panelTop.BackColor = System.Drawing.Color.Black;
			this.panelTop.Controls.Add(this.panelTitle);
			this.panelTop.Controls.Add(this.btnClose);
			this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTop.Location = new System.Drawing.Point(0, 0);
			this.panelTop.Name = "panelTop";
			this.panelTop.Size = new System.Drawing.Size(448, 40);
			this.panelTop.TabIndex = 1;
			// 
			// panelTitle
			// 
			this.panelTitle.Controls.Add(this.lblPanelTitle);
			this.panelTitle.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelTitle.Location = new System.Drawing.Point(0, 0);
			this.panelTitle.Name = "panelTitle";
			this.panelTitle.Size = new System.Drawing.Size(256, 40);
			this.panelTitle.TabIndex = 0;
			// 
			// lblPanelTitle
			// 
			this.lblPanelTitle.AutoSize = true;
			this.lblPanelTitle.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPanelTitle.ForeColor = System.Drawing.Color.White;
			this.lblPanelTitle.Location = new System.Drawing.Point(15, 10);
			this.lblPanelTitle.Name = "lblPanelTitle";
			this.lblPanelTitle.Size = new System.Drawing.Size(154, 19);
			this.lblPanelTitle.TabIndex = 1;
			this.lblPanelTitle.Text = "AfraidPikunFlower";
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.Black;
			this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.ForeColor = System.Drawing.Color.Black;
			this.btnClose.Location = new System.Drawing.Point(412, 4);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(33, 33);
			this.btnClose.TabIndex = 1;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.ucScrollbar1);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 40);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(448, 341);
			this.panel1.TabIndex = 5;
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.Black;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.textBox1.ForeColor = System.Drawing.Color.White;
			this.textBox1.Location = new System.Drawing.Point(0, 0);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox1.Size = new System.Drawing.Size(448, 341);
			this.textBox1.TabIndex = 5;
			// 
			// ucScrollbar1
			// 
			this.ucScrollbar1.ChannelColor = System.Drawing.Color.Black;
			this.ucScrollbar1.DownArrowImage = ((System.Drawing.Image)(resources.GetObject("ucScrollbar1.DownArrowImage")));
			this.ucScrollbar1.LargeChange = 10;
			this.ucScrollbar1.Location = new System.Drawing.Point(430, 0);
			this.ucScrollbar1.Maximum = 100;
			this.ucScrollbar1.Minimum = 0;
			this.ucScrollbar1.MinimumSize = new System.Drawing.Size(15, 92);
			this.ucScrollbar1.Name = "ucScrollbar1";
			this.ucScrollbar1.Size = new System.Drawing.Size(18, 341);
			this.ucScrollbar1.SmallChange = 1;
			this.ucScrollbar1.TabIndex = 6;
			this.ucScrollbar1.ThumbBottomImage = ((System.Drawing.Image)(resources.GetObject("ucScrollbar1.ThumbBottomImage")));
			this.ucScrollbar1.ThumbBottomSpanImage = ((System.Drawing.Image)(resources.GetObject("ucScrollbar1.ThumbBottomSpanImage")));
			this.ucScrollbar1.ThumbMiddleImage = ((System.Drawing.Image)(resources.GetObject("ucScrollbar1.ThumbMiddleImage")));
			this.ucScrollbar1.ThumbTopImage = ((System.Drawing.Image)(resources.GetObject("ucScrollbar1.ThumbTopImage")));
			this.ucScrollbar1.ThumbTopSpanImage = ((System.Drawing.Image)(resources.GetObject("ucScrollbar1.ThumbTopSpanImage")));
			this.ucScrollbar1.UpArrowImage = ((System.Drawing.Image)(resources.GetObject("ucScrollbar1.UpArrowImage")));
			this.ucScrollbar1.Value = 0;
			// 
			// NewsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(448, 381);
			this.ControlBox = false;
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panelTop);
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "NewsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.panelTop.ResumeLayout(false);
			this.panelTitle.ResumeLayout(false);
			this.panelTitle.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}
		#endregion

		private System.Windows.Forms.Panel panelTop;
		private System.Windows.Forms.Panel panelTitle;
		private System.Windows.Forms.Label lblPanelTitle;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Panel panel1;
		private CustomControls.UCScrollbar ucScrollbar1;
		private System.Windows.Forms.TextBox textBox1;
	}
}