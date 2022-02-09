using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using Helper;

namespace WFA.OCR.UserControls
{
    public partial class UCClientBody : UserControl
    {
        public UCClientBody()
        {
            InitializeComponent();
        }

        #region event
        #endregion

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            if (!MainForm.Instance.PnlClientBody.Controls.ContainsKey("UCClientOcr"))
            {
                UserControlHelper.SetUserControl(MainForm.Instance.PnlClientBody, userControl: new UCClientOcr(), dockStyle: UserControlDockStyle.DockStyleFill);
            }
            MainForm.Instance.PnlClientBody.Controls["UCClientOcr"].BringToFront();
            MainForm.Instance.PnlTitle.BackColor = Color.FromArgb(32, 32, 32);
        }

		private void btnAboutMe_Click(object sender, EventArgs e)
		{
			if (!MainForm.Instance.PnlClientBody.Controls.ContainsKey("UCClientAboutMe"))
			{
				UserControlHelper.SetUserControl(MainForm.Instance.PnlClientBody, userControl: new UCClientAboutMe(), dockStyle: UserControlDockStyle.DockStyleFill);
			}
			MainForm.Instance.PnlClientBody.Controls["UCClientAboutMe"].BringToFront();
			MainForm.Instance.PnlTitle.BackColor = Color.FromArgb(32, 32, 32);
		}
	}
}
