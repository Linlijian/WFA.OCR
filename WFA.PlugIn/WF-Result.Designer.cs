namespace WFA.PlugIn
{
    partial class ResultList
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultList));
			this.btnClose = new System.Windows.Forms.Button();
			this.lblStatus = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnCopySource = new System.Windows.Forms.Button();
			this.txtSource = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnCopyTarGet = new System.Windows.Forms.Button();
			this.txtTarget = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnClose.BackgroundImage = global::WFA.PlugIn.Image.ImageResource.delete_32px;
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.ForeColor = System.Drawing.Color.Black;
			this.btnClose.Location = new System.Drawing.Point(586, 4);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(33, 33);
			this.btnClose.TabIndex = 2;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStatus.ForeColor = System.Drawing.Color.White;
			this.lblStatus.Location = new System.Drawing.Point(12, 16);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(54, 19);
			this.lblStatus.TabIndex = 3;
			this.lblStatus.Text = "Result";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnCopySource);
			this.groupBox1.Controls.Add(this.txtSource);
			this.groupBox1.Font = new System.Drawing.Font("Itim", 12F);
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(16, 38);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(595, 174);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Source";
			// 
			// btnCopySource
			// 
			this.btnCopySource.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnCopySource.BackgroundImage = global::WFA.PlugIn.Image.ImageResource.copy_24px;
			this.btnCopySource.FlatAppearance.BorderSize = 0;
			this.btnCopySource.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
			this.btnCopySource.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.btnCopySource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCopySource.ForeColor = System.Drawing.Color.Black;
			this.btnCopySource.Location = new System.Drawing.Point(563, 137);
			this.btnCopySource.Name = "btnCopySource";
			this.btnCopySource.Size = new System.Drawing.Size(22, 22);
			this.btnCopySource.TabIndex = 6;
			this.btnCopySource.UseVisualStyleBackColor = false;
			this.btnCopySource.Click += new System.EventHandler(this.btnCopySource_Click);
			// 
			// txtSource
			// 
			this.txtSource.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtSource.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtSource.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSource.ForeColor = System.Drawing.Color.White;
			this.txtSource.Location = new System.Drawing.Point(6, 26);
			this.txtSource.Multiline = true;
			this.txtSource.Name = "txtSource";
			this.txtSource.Size = new System.Drawing.Size(547, 133);
			this.txtSource.TabIndex = 14;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnCopyTarGet);
			this.groupBox2.Controls.Add(this.txtTarget);
			this.groupBox2.Font = new System.Drawing.Font("Itim", 12F);
			this.groupBox2.ForeColor = System.Drawing.Color.White;
			this.groupBox2.Location = new System.Drawing.Point(16, 218);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(595, 174);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Target";
			// 
			// btnCopyTarGet
			// 
			this.btnCopyTarGet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnCopyTarGet.BackgroundImage = global::WFA.PlugIn.Image.ImageResource.copy_24px;
			this.btnCopyTarGet.FlatAppearance.BorderSize = 0;
			this.btnCopyTarGet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
			this.btnCopyTarGet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.btnCopyTarGet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCopyTarGet.ForeColor = System.Drawing.Color.Black;
			this.btnCopyTarGet.Location = new System.Drawing.Point(563, 137);
			this.btnCopyTarGet.Name = "btnCopyTarGet";
			this.btnCopyTarGet.Size = new System.Drawing.Size(22, 22);
			this.btnCopyTarGet.TabIndex = 16;
			this.btnCopyTarGet.UseVisualStyleBackColor = false;
			this.btnCopyTarGet.Click += new System.EventHandler(this.btnCopyTarGet_Click);
			// 
			// txtTarget
			// 
			this.txtTarget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.txtTarget.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtTarget.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTarget.ForeColor = System.Drawing.Color.White;
			this.txtTarget.Location = new System.Drawing.Point(6, 26);
			this.txtTarget.Multiline = true;
			this.txtTarget.Name = "txtTarget";
			this.txtTarget.Size = new System.Drawing.Size(547, 133);
			this.txtTarget.TabIndex = 15;
			// 
			// ResultList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(623, 414);
			this.ControlBox = false;
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.btnClose);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ResultList";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtSource;
		private System.Windows.Forms.TextBox txtTarget;
		private System.Windows.Forms.Button btnCopySource;
		private System.Windows.Forms.Button btnCopyTarGet;
	}
}