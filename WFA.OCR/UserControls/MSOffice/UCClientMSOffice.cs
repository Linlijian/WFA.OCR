using Helper;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WFA.OCR.UserControls
{
	public partial class UCClientMSOffice : UserControl
	{
		#region init
		public UCClientMSOffice()
		{
			InitializeComponent();
			HideActive();
		}
		#endregion

		#region form
		private void UCClientMSOffice_Load(object sender, EventArgs e)
		{
			Global.PActiveHide(panelClient);
			Global.PActiveShow(PActive1);
			UserControlHelper.SetUserControl(panelClientTask, userControl: new UCMSO001(), dockStyle: UserControlDockStyle.DockStyleFill);
		}
		#endregion

		#region event
		private void btnHome_Click(object sender, EventArgs e)
		{
			MainForm.Instance.PnlTitle.BackColor = Color.Black;
			if (!MainForm.Instance.PnlClientBody.Controls.ContainsKey("UCClientBody"))
			{
				UserControlHelper.SetUserControl(MainForm.Instance.PnlClientBody, userControl: new UCClientBody(), dockStyle: UserControlDockStyle.DockStyleFill);
			}
			MainForm.Instance.PnlClientBody.Controls["UCClientBody"].BringToFront();
		}
		private void btnGenerateWord_Click(object sender, EventArgs e)
		{
			Global.PActiveHide(panelClient);
			Global.PActiveShow(PActive1);
			UserControlHelper.SetUserControl(panelClientTask, userControl: new UCMSO001(), dockStyle: UserControlDockStyle.DockStyleFill);
		}
		#endregion

		#region method
		public void HideActive()
		{
			PActive1.Hide();
		}
		#endregion
	}
}
