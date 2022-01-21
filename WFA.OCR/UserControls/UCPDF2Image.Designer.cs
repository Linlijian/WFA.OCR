namespace WFA.OCR.UserControls
{
    partial class UCPDF2Image
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
            this.btnHome = new System.Windows.Forms.Button();
            this.lblActiveTask = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnConvert2Image = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnConvertInFolder = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnConvertInMulFolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = global::WFA.PlugIn.Image.ImageResource.home_32px;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(12, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(244, 35);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblActiveTask
            // 
            this.lblActiveTask.AutoSize = true;
            this.lblActiveTask.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveTask.ForeColor = System.Drawing.Color.White;
            this.lblActiveTask.Location = new System.Drawing.Point(8, 76);
            this.lblActiveTask.Name = "lblActiveTask";
            this.lblActiveTask.Size = new System.Drawing.Size(101, 19);
            this.lblActiveTask.TabIndex = 2;
            this.lblActiveTask.Text = "PDF to Image";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
            this.panel2.Location = new System.Drawing.Point(0, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 35);
            this.panel2.TabIndex = 4;
            // 
            // btnConvert2Image
            // 
            this.btnConvert2Image.BackgroundImage = global::WFA.PlugIn.Image.ImageResource.home_32px;
            this.btnConvert2Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConvert2Image.FlatAppearance.BorderSize = 0;
            this.btnConvert2Image.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvert2Image.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert2Image.ForeColor = System.Drawing.Color.White;
            this.btnConvert2Image.Location = new System.Drawing.Point(12, 161);
            this.btnConvert2Image.Name = "btnConvert2Image";
            this.btnConvert2Image.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnConvert2Image.Size = new System.Drawing.Size(244, 35);
            this.btnConvert2Image.TabIndex = 3;
            this.btnConvert2Image.Text = "Convert to Image";
            this.btnConvert2Image.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConvert2Image.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
            this.panel3.Location = new System.Drawing.Point(0, 200);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 35);
            this.panel3.TabIndex = 6;
            // 
            // btnConvertInFolder
            // 
            this.btnConvertInFolder.BackgroundImage = global::WFA.PlugIn.Image.ImageResource.home_32px;
            this.btnConvertInFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConvertInFolder.FlatAppearance.BorderSize = 0;
            this.btnConvertInFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertInFolder.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertInFolder.ForeColor = System.Drawing.Color.White;
            this.btnConvertInFolder.Location = new System.Drawing.Point(12, 202);
            this.btnConvertInFolder.Name = "btnConvertInFolder";
            this.btnConvertInFolder.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnConvertInFolder.Size = new System.Drawing.Size(244, 35);
            this.btnConvertInFolder.TabIndex = 5;
            this.btnConvertInFolder.Text = "Convert in Folder";
            this.btnConvertInFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConvertInFolder.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(125)))), ((int)(((byte)(154)))));
            this.panel4.Location = new System.Drawing.Point(0, 241);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 35);
            this.panel4.TabIndex = 8;
            // 
            // btnConvertInMulFolder
            // 
            this.btnConvertInMulFolder.BackgroundImage = global::WFA.PlugIn.Image.ImageResource.home_32px;
            this.btnConvertInMulFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConvertInMulFolder.FlatAppearance.BorderSize = 0;
            this.btnConvertInMulFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertInMulFolder.Font = new System.Drawing.Font("Itim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertInMulFolder.ForeColor = System.Drawing.Color.White;
            this.btnConvertInMulFolder.Location = new System.Drawing.Point(12, 243);
            this.btnConvertInMulFolder.Name = "btnConvertInMulFolder";
            this.btnConvertInMulFolder.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnConvertInMulFolder.Size = new System.Drawing.Size(244, 35);
            this.btnConvertInMulFolder.TabIndex = 7;
            this.btnConvertInMulFolder.Text = "Convert in Multi Folder";
            this.btnConvertInMulFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConvertInMulFolder.UseVisualStyleBackColor = true;
            // 
            // UCPDF2Image
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnConvertInMulFolder);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnConvertInFolder);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnConvert2Image);
            this.Controls.Add(this.lblActiveTask);
            this.Controls.Add(this.btnHome);
            this.Name = "UCPDF2Image";
            this.Size = new System.Drawing.Size(256, 560);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblActiveTask;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnConvert2Image;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnConvertInFolder;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnConvertInMulFolder;
    }
}
