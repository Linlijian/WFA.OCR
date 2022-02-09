using Helper;
using System;
using System.Threading;
using System.Windows.Forms;
using UtilityLib;
using WFA.OCR.UserControls;
using WFA.PlugIn;
using HotkeyManagement;

namespace WFA.OCR
{
    public partial class MainForm : Form
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

		#region init
		static MainForm _obj;

        public static MainForm Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new MainForm();
                }
                return _obj;
            }
        }

        public Panel PnlClientBody
        {
            get { return panelClientBody; }
            set { panelClientBody = value; }
        }
        public Panel PnlTitle
        {
            get { return panelTitle; }
            set { panelTitle = value; }
        }

		public LocalHotKey _KCaptureArea = null;
		public LocalHotKey KCaptureArea
		{
			get { return _KCaptureArea; }
			set { _KCaptureArea = value; }
		}

		internal HotKeyManager _MyHotKeyManager;
		public HotKeyManager MyHotKeyManager
		{
			get { return _MyHotKeyManager; }
			set { _MyHotKeyManager = value; }
		}

		public MainForm()
        {
			//Thread t = new Thread(new ThreadStart(StartUp));
			//t.Start();
			//Thread.Sleep(2000);
			//InitializeComponent();
			//Thread.Sleep(10);
			//t.Abort();

			using (SplashScreen form = new SplashScreen(StartUp))
			{
				form.ShowDialog(this);
			}


			InitializeComponent();
		}
        public void StartUp()
        {
            //Application.Run(new SplashScreen());
        }
        #endregion

        #region form
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!SessionHelper.SYS_START_UP)
            {
                //that work!
                var message = new MassageBoxModel();
                message.TITLE = SessionHelper.SYS_TITLE;
                message.MESSAGE = SessionHelper.SYS_ERROR_CODE + " : " + SessionHelper.SYS_ERROR_MESSAGE;
                message.BUTTON_TYPE = ButtonType.OK;

                using (MassageBox box = new MassageBox(message))
                {
                    box.ShowDialog(this);
                }

                Application.Exit();
            }
            else
            {
                _obj = this;

				MyHotKeyManager = new HotKeyManager(this);
				MyHotKeyManager.LocalHotKeyPressed += new LocalHotKeyEventHandler(KCaptureAreaHotkey);
				MyHotKeyManager.DisableOnManagerFormInactive = true;

				if (!SessionHelper.SYS_HOTKEY.IsNullOrEmpty())
				{
					KCaptureArea = new LocalHotKey("KCaptureArea", SessionHelper.SYS_HOTKEY.KeyEmun());
					MyHotKeyManager.AddLocalHotKey(KCaptureArea);
					KCaptureArea.Enabled = true;
				}

				UserControlHelper.SetUserControl(panelClientBody, userControl: new UCClientBody(), dockStyle: UserControlDockStyle.DockStyleFill);
            }  
        }
        #endregion

        #region btn
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
		private void btnHome_Click(object sender, EventArgs e)
		{
			PnlClientBody.Controls["UCClientBody"].BringToFront();
		}
		#endregion

		#region panel

		#endregion

		#region even
		public void KCaptureAreaHotkey(object sender, LocalHotKeyEventArgs e)
		{
			switch (e.HotKey.Name.ToUpper())
			{

				case "KCAPTUREAREA":
					this.Hide();
					CaptureAreaForm caf = new CaptureAreaForm();
					caf.InstanceRef = this;
					caf.Show();
					return;


				default:
					if (e.HotKey.Tag != null) System.Diagnostics.Process.Start((string)e.HotKey.Tag);
					break;
			}
		}
		#endregion
	}
}