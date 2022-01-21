using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using Helper;

namespace WFA.OCR.UserControls
{
    public partial class ExampleScollbar : UserControl
    {
		public ExampleScollbar()
        {
            InitializeComponent();
		}

		#region event
		#endregion
		
		private void btnexam_Click(object sender, EventArgs e)
        {
            if (!MainForm.Instance.PnlClientBody.Controls.ContainsKey("UCClientExam"))
            {
                UserControlHelper.SetUserControl(MainForm.Instance.PnlClientBody, userControl: new UCClientExam(), dockStyle: UserControlDockStyle.DockStyleFill);
            }
            MainForm.Instance.PnlClientBody.Controls["UCClientExam"].BringToFront();
            MainForm.Instance.PnlTitle.BackColor = Color.FromArgb(32, 32, 32);
        }
	}
}
