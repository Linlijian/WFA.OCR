using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilityLib;

namespace WFA.OCR
{
	public partial class Overlay : Form
	{
		public string WINDOWN_TITLE { get; set; }

		public Overlay(string win_title)
		{
			WINDOWN_TITLE = win_title;
			InitializeComponent();
		}

		private void Overlay_Load(object sender, EventArgs e)
		{
			
			IntPtr handle = WinAPI.FindWindow(null, WINDOWN_TITLE);
			WinAPI.RECT rect;

			this.BackColor = Color.Wheat;
			this.TransparencyKey = Color.Wheat;
			this.TopMost = true;
			this.FormBorderStyle = FormBorderStyle.None;

			int initialStyle = WinAPI.GetWindowLong(this.Handle, -20);
			WinAPI.SetWindowLong(this.Handle, -20, initialStyle | 0x80000 | 0x20);


			WinAPI.GetWindowRect(handle, out rect);
			this.Size = new Size(rect.right - rect.left, rect.bottom - rect.top);
			this.Top = rect.top;
			this.Left = rect.left;
		}
	}
}
