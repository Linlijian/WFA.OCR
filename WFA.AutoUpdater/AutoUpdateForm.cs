using SevenZip;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using WFA.OCR.Helper;
using WFA.PlugIn;

namespace WFA.AutoUpdater
{
    public partial class AutoUpdateForm : Form
    {

        public AutoUpdateForm()
        {
            InitializeComponent();
        }

		private void AutoUpdaterForm_Load(object sender, EventArgs e)
		{
			pbAnimetion.Image = Properties.Resources.Sprite_006;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

			string txt_err = string.Empty;
			try
			{
				txt_err = "Get Main Info";
				FileVersionInfo main_info = GetMainInfo();

				txt_err = "Ge tMain Online Version";
				string main_online_version = GetMainOnlineVersion();

				if (main_info.FileVersion != main_online_version)
				{
					//เปิดปิดกรณีให้อัพเดทใหม่ autoupdater
					Download();
				}
			}
			catch (Exception ex)
			{
				PluginHelper.MassageBox("Fail", txt_err + "\r\n" + ex.Message, ButtonType.OK);
			}
		}

		private FileVersionInfo GetMainInfo()
		{
			var all_file = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "*.exe");
			foreach (var file in all_file)
			{
				FileVersionInfo info = FileVersionInfo.GetVersionInfo(file);
				if (info.ProductName == "WFA.OCR")
				{
					return FileVersionInfo.GetVersionInfo(file);
				}
			}

			return null;
		}
		private string GetMainOnlineVersion()
		{
			string url = "https://raw.githubusercontent.com/Linlijian/PikunBot-Mir4/main/version.txt";
			WebClient client = new WebClient();
			Stream stream = client.OpenRead(url);
			StreamReader reader = new StreamReader(stream);

			return reader.ReadToEnd();
		}
		private void Download()
		{
			WebClient webClient = new WebClient();

			string zipPath = @"D:\WFA\test\testZip.zip";
			string extractPath = @"D:\WFA\test\extract";

			ZipFile.ExtractToDirectory(zipPath, extractPath);
			//var a = new ZipFile(zipPath);
			//a.ExtractAll(extractPath);

			//foreach (var item in dto.Model.CLB_LANGUAGE_LIST)
			//{
			//	var link = "";
			//	var file_tar = dto.Model.TESS_PATH + "\\" + link.LANGUAGE_CODE;
			//	var file_sou = dto.Model.TEMP_PATH + "\\" + link.LANGUAGE_CODE;
			//	webClient.DownloadFile(link.LANGUAGE_LINK, file_sou);

			//	string startPath = @"D:\WFA\WFA.CSSGenerator";
			//	string zipPath = @"D:\WFA\WFA-WebClientAndZip-master\WFA-WebClient\bin\Debug2\test.rar";
			//	string extractPath = @"D:\WFA\WFA-WebClientAndZip-master\WFA-WebClient\bin\Debug2\extract";

			//	var a = new ZipFile(zipPath);
			//	a.ExtractAll(extractPath);

			//	if (File.Exists(file_tar))
			//		File.Delete(file_tar);
			//	File.Move(file_sou, file_tar);
			//}
		}
		
    }
}

