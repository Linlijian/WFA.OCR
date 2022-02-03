using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilityLib;
using WFA.PlugIn;

namespace WFA.PlugIn
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            VerifyStartUp();
        }
		private void VerifyStartUp()
		{
			try
			{
				//load .pikun
				lblStatus.Text = "Load Config";

				if (Directory.Exists(SessionHelper.SYS_PATH))
				{
					if (!ReadConfig()) return;
				}
				else
				{
					lblStatus.Text = "Create Folder Config";
					string result = IOHelper.CreateConfig(SessionHelper.SYS_PATH, SessionHelper.SYS_CONFIG_PATH);
					if (!result.IsNullOrEmpty())
					{
						SetError(result, "000", "Fail");
						return;
					}

					//read file
					if (!ReadConfig()) return;
				}

				SessionHelper.SYS_START_UP = true;
			}
			catch (Exception e)
			{
				SetError(lblStatus.Text + " " + e.Message, "001", "Error");
			}
        }

		private void SetError(string _text, string _code, string _title)
		{
			SessionHelper.SYS_START_UP = false;
			SessionHelper.SYS_ERROR_CODE = _code;
			SessionHelper.SYS_ERROR_MESSAGE = "Cann't Load config\r\n" + _text;
			SessionHelper.SYS_TITLE = _title;
		}
		private bool ReadConfig()
		{
			string config = IOHelper.GetFile(SessionHelper.SYS_PATH);
			if (config.IsNullOrEmpty())
			{
				lblStatus.Text = "Not found file ==> Create Folder Config";
				string result = IOHelper.CreateFile(SessionHelper.SYS_CONFIG_PATH);
				if (!result.IsNullOrEmpty())
				{
					SetError(result, "000", "Fail");
					return false;
				}

				config = IOHelper.GetFile(SessionHelper.SYS_PATH);
			}
			
			var arr = IOHelper.ReadConfig(config);

			lblStatus.Text = "Load Hotkey";
			SessionHelper.SYS_HOTKEY = arr.Where(a => a.Contains("Hotkey")).FirstOrDefault().Split(':').Last();

			//check tessdata in file
			lblStatus.Text = "Create Folder TessData";
			IOHelper.CreateFolder(SessionHelper.SYS_TESSDATA_PATH);

			return true;
		}
	}
}
