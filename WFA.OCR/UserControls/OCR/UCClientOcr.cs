using Helper;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WFA.OCR.UserControls
{
	public partial class UCClientOcr : UserControl
	{
		bool ACTIVE = false;
		public UCClientOcr()
		{
			InitializeComponent();
			panelSetting.Hide(); // hide menu setting
			PSubTranslate1.Hide();
			PSubTranslate2.Hide();
			HideActive();
		}
		public void HideActive()
		{
			PActive1.Hide();
			PActive2.Hide();
			PSActiveDownloadV3.Hide();
			PSActiveDownloadV4.Hide();
		}

		private void btnTranslate_Click(object sender, EventArgs e)
		{
			if (ACTIVE)
			{
				Global.PActiveHide(panelClient);
				Global.PSActiveHide(panelClient);

				Global.PActiveShow(PActive1);

				Global.PHideMenu(PSubTranslate1);
				Global.PHideMenu(PSubTranslate2);

				UserControlHelper.SetUserControl(panelClientTask, userControl: new UCOCR001(), dockStyle: UserControlDockStyle.DockStyleFill);

				ACTIVE = false;
			}
			else
			{
				Global.PActiveHide(panelClient);
				Global.PActiveShow(PActive1);

				Global.PShowMenu(PSubTranslate1);
				Global.PShowMenu(PSubTranslate2);

				UserControlHelper.SetUserControl(panelClientTask, userControl: new UCOCR001(), dockStyle: UserControlDockStyle.DockStyleFill);

				ACTIVE = true;
			}
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

		private void btnDownloadV3_Click(object sender, EventArgs e)
		{
			Global.PSActiveHide(panelClient);
			Global.PActiveHide(panelClient, PActive1);
			Global.PSActiveShow(PSActiveDownloadV3);
			UserControlHelper.SetUserControl(panelClientTask, userControl: new UCOCRS01(), dockStyle: UserControlDockStyle.DockStyleFill);
		}

		private void btnDownloadV41_Click(object sender, EventArgs e)
		{
			Global.PSActiveHide(panelClient);
			Global.PActiveHide(panelClient, PActive1);
			Global.PSActiveShow(PSActiveDownloadV4);
			UserControlHelper.SetUserControl(panelClientTask, userControl: new UCOCRS02(), dockStyle: UserControlDockStyle.DockStyleFill);
		}
	}
}
