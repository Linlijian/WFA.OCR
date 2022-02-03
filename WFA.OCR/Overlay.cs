﻿using Helper;
using HotkeyManagement;
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
		LocalHotKey lhkClearLog;
		internal HotKeyManager MyHotKeyManager;
		GlobalHotKey ghkNotepad;

		public Overlay(string win_title)
		{
			InitializeComponent();

			WINDOWN_TITLE = win_title;
			MyHotKeyManager = new HotKeyManager(this);
			MyHotKeyManager.LocalHotKeyPressed += new LocalHotKeyEventHandler(MyHotKeyManager_LocalHotKeyPressed);

			//load hotkey from file
			lhkClearLog = new LocalHotKey("lhkClearLog", Keys.Escape);
			lhkClearLog.Enabled = true;
			MyHotKeyManager.AddLocalHotKey(lhkClearLog);
			MyHotKeyManager.DisableOnManagerFormInactive = true;

			//สร้าวโรปแกรมแสดงรูปเวลาแคปหน้าจอแล้วใส่ข้ความลงไปไม่ใช่ overal
			//แต่เป็น from ธรรมดา
		}

		private void Overlay_Load(object sender, EventArgs e)
		{
			IntPtr handle = WinAPI.FindWindow(null, WINDOWN_TITLE);
			WinAPI.RECT rect;

			this.BackColor = Color.Wheat;
			this.TransparencyKey = Color.Wheat;
			this.TopMost = true;
			//this.FormBorderStyle = FormBorderStyle.None;

			int initialStyle = WinAPI.GetWindowLong(this.Handle, -20);
			WinAPI.SetWindowLong(this.Handle, -20, initialStyle | 0x80000 | 0x20);


			WinAPI.GetWindowRect(handle, out rect);
			this.Size = new Size(rect.right - rect.left, rect.bottom - rect.top);
			this.Top = rect.top;
			this.Left = rect.left;
		}

		private void CreateLabel(Panel panelOverly, string text, int x, int y)
		{
			Label l = new Label();
			l.AutoSize = true;
			l.Font = new Font("Itim", 14.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(222)));
			l.Location = new Point(x, y);
			l.Name = "lbl"+x.ToString();
			l.Size = new Size(86, 23);
			l.TabIndex = 0;
			l.Text = text;

			panelOverly.Controls.Add(l);
		}

		private Panel CreatePanel()
		{
			Panel panelOverly = new Panel();
			panelOverly.SuspendLayout();
			panelOverly.Dock = DockStyle.Fill;
			panelOverly.Location = new Point(0, 0);
			panelOverly.Name = "panelOverly";
			panelOverly.Size = new Size(284, 261);
			panelOverly.TabIndex = 1;

			this.Controls.Add(panelOverly);

			return panelOverly;
		}

		private void Hotkeytest()
		{
			Panel panelOverly = CreatePanel();
			CreateLabel(panelOverly, "test", 210, 41);
			CreateLabel(panelOverly, "test1", 40, 140);
			CreateLabel(panelOverly, "test2", 630, 240);
			CreateLabel(panelOverly, "test3", 80, 340);
			CreateLabel(panelOverly, "test4", 1100, 440);
		}

		private void TestTooltip()
		{
			ToolTip tt = new ToolTip();
			IWin32Window win = this;
			System.Drawing.Point mousePosition = Cursor.Position;
			tt.Show("String\r\naaaaaaaaaaaaaaaaaaa", win, mousePosition);
		}

		void MyHotKeyManager_GlobalHotKeyPressed(object sender, GlobalHotKeyEventArgs e)
		{
			System.Diagnostics.Process.Start((e.HotKey.Tag as string));
		}

		void MyHotKeyManager_LocalHotKeyPressed(object sender, LocalHotKeyEventArgs e)
		{
			switch (e.HotKey.Name.ToLower())
			{
				
				case "lhkclearlog":
					TestTooltip();
					return;

				
				default:
					if (e.HotKey.Tag != null) System.Diagnostics.Process.Start((string)e.HotKey.Tag);
					break;
			}
		}
	}
}
