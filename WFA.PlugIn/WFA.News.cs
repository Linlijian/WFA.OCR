using System;
using System.Windows.Forms;
using UtilityLib;

namespace WFA.PlugIn
{
	public partial class News : Form
	{
		#region Move
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		private void panelTop_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}
		private void panelTitle_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}
		private void lblPanelTitle_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}
		#endregion

		public News()
		{
			InitializeComponent();

			var size_arr = SessionHelper.SYS_NEWS.Split(new string[] { "\r\n" }, StringSplitOptions.None);
			int size = size_arr.Length - 1;
			if (size * 25 <= 200)
			{
				int new_size = (size * 25);
				this.txtMessage.Size = new System.Drawing.Size(337, new_size);
				if(size * 20 > 100) this.ClientSize = new System.Drawing.Size(360, 390 + (20 * size));
				this.ucScrollbar.Visible = false;
			}
			else
			{
				int new_size = 200;
				this.txtMessage.Size = new System.Drawing.Size(337, new_size);
				this.ClientSize = new System.Drawing.Size(360, 390 + (20 * 8));
				this.ucScrollbar.Visible = true;
			}

			txtMessage.Text = SessionHelper.SYS_NEWS;
			pbAniemtion.Image = Image.ImageResource.neko2;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
