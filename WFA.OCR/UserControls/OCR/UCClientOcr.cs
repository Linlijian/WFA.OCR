using Helper;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WFA.OCR.UserControls
{
	public partial class UCClientOcr : UserControl
	{
		public UCClientOcr()
		{
			InitializeComponent();
			HideActive();
		}
		public void HideActive()
		{
			PActive1.Hide();
			PActive2.Hide();
		}

		private void btnTranslate_Click(object sender, EventArgs e)
		{
			Global.PActiveHide(panelClient);
			Global.PActiveShow(PActive1);
			UserControlHelper.SetUserControl(panelClientTask, userControl: new UCOCR001(), dockStyle: UserControlDockStyle.DockStyleFill);
		}

		private void btnSetting_Click(object sender, EventArgs e)
		{
			Global.PActiveHide(panelClient);
			Global.PActiveShow(PActive2);
			UserControlHelper.SetUserControl(panelClientTask, userControl: new UCOCR002(), dockStyle: UserControlDockStyle.DockStyleFill);
		}

		private void btnHome_Click(object sender, EventArgs e)
		{
			MainForm.Instance.PnlTitle.BackColor = Color.Black;
			if (!MainForm.Instance.PnlClientBody.Controls.ContainsKey("UCClientBody"))
			{
				UserControlHelper.SetUserControl(MainForm.Instance.PnlClientBody, userControl: new UCClientBody(), dockStyle: UserControlDockStyle.DockStyleFill);
			}
			MainForm.Instance.PnlClientBody.Controls["UCClientBody"].BringToFront();
		}
	}
}
