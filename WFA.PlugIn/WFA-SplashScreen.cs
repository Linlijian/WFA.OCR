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
		public Action Worker { get; set; }
		public SplashScreen(Action _worker)
        {
            InitializeComponent();
            VerifyStartUp();
			if (_worker == null)
				throw new ArgumentNullException();
			Worker = _worker;
		}
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			Task.Factory.StartNew(Worker).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
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

				#region load ddl
				lblStatus.Text = "Load DropdownList from Tessdata";
				if (Directory.Exists(SessionHelper.SYS_TESSDATA_PATH))
				{
					var config = IOHelper.ReadFolderTrainData(SessionHelper.SYS_TESSDATA_PATH);
					var sou_lang = new List<DropDownList>();
					var tar_lang = new List<DropDownList>();

					foreach (var item in config)
					{
						tar_lang.Add(new DropDownList { TEXT = IOHelper.GetTextLang(item), VALUE = item });
					}
					SessionHelper.SYS_TAR_LANGUAGES = tar_lang;

					foreach (var item in SessionHelper.SYS_GOOGLE_LANGUAGES.Split(new string[] { "\r\n", ";" }, StringSplitOptions.None))
					{
						if (!item.IsNullOrEmpty())
						{
							var values = item.Split(':');
							sou_lang.Add(new DropDownList
							{
								TEXT = values[0],
								VALUE = values[1],
								REMARK = values[2]
							});
						}
					}

					SessionHelper.SYS_SOU_LANGUAGES = sou_lang.Where(s => !s.REMARK.IsNullOrEmpty()).ToList();
				}
				else
				{
					SetError(lblStatus.Text, "000", "Fail");
					return;
				}
				#endregion

				#region load file tassdata
				lblStatus.Text = "Load TainData from Tessdata";
				if (!Directory.Exists(SessionHelper.SYS_TESSDATA_PATH))
				{
					SetError(lblStatus.Text, "000", "Fail");
					return;
				}
				#endregion

				SessionHelper.SYS_START_UP = true;
			}
			catch (Exception e)
			{
				SetError(lblStatus.Text + " " + e.Message, "001", "Error");
				return;
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

			lblStatus.Text = "Load Source Language";
			SessionHelper.SYS_SOU_LANGUAGE = arr.Where(a => a.Contains("SourceLanguage")).FirstOrDefault().Split(':').Last();

			lblStatus.Text = "Load Target Language";
			SessionHelper.SYS_TAR_LANGUAGE = arr.Where(a => a.Contains("TargetLanguage")).FirstOrDefault().Split(':').Last();

			lblStatus.Text = "Load Google Language";
			SessionHelper.SYS_GOO_LANGUAGE = arr.Where(a => a.Contains("GoogleLanguage")).FirstOrDefault().Split(':').Last();

			//check tessdata in file
			lblStatus.Text = "Create Folder TessData";
			IOHelper.CreateFolder(SessionHelper.SYS_TESSDATA_PATH);

			return true;
		}
	}
}
