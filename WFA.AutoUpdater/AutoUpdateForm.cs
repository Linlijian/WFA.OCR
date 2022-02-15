using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;
using WFA.OCR.Helper;
using WFA.PlugIn;

namespace WFA.AutoUpdater
{
    public partial class AutoUpdateForm : Form
    {
		#region init
		private bool downloading_process_notcomplete = true;
		private string url_version = @"https://raw.githubusercontent.com/Linlijian/WFA.OCR/master/WFA.OCR/Version/version.txt";
		private string url_donwload_file = @"https://github.com/Linlijian/WFA.OCR/raw/master/WFA.OCR/Deploy/Deploy.zip";
		private string download_file_path = Path.GetTempPath() + "WFA.OCR//WFA.OCR.zip";
		private string download_folder_path = Path.GetTempPath() + "WFA.OCR";
		private string extract_path = AppDomain.CurrentDomain.BaseDirectory;


		public AutoUpdateForm()
        {
            InitializeComponent();
        }
		private void AutoUpdaterForm_Load(object sender, EventArgs e)
		{
			pbAnimetion.Image = Properties.Resources.Sprite_006;
			DownloadingWorker.RunWorkerAsync();
		}
		#endregion

		#region event
		private void DownloadingWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			BackgroundWorker helperBW = sender as BackgroundWorker;
			while (downloading_process_notcomplete)
			{
				mainProcess(helperBW);
			}
		}
		private void DownloadingWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.Close();
		}
		private void mainProcess(BackgroundWorker bw)
		{
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

			string txt_err = string.Empty;
			try
			{
				txt_err = "Get Main Info";
				FileVersionInfo main_info = GetMainInfo("WFA.OCR");

				txt_err = "Get Main Online Version";
				string main_online_version = GetMainOnlineVersion();

				if (main_info.FileVersion != main_online_version)
				{
					IsUpdateNewAutoUpdater();
				}
			}
			catch (Exception ex)
			{
				PluginHelper.MassageBox("Fail", txt_err + "\r\n" + ex.Message, ButtonType.OK);
			}
			finally
			{
				//close worker
				downloading_process_notcomplete = false;
				Application.Exit();
			}
		}
		#endregion

		#region method
		private FileVersionInfo GetMainInfo(string product_name)
		{
			var all_file = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "*.exe");
			foreach (var file in all_file)
			{
				FileVersionInfo info = FileVersionInfo.GetVersionInfo(file);
				if (info.ProductName == product_name)
				{
					return FileVersionInfo.GetVersionInfo(file);
				}
			}

			return null;
		}
		private string GetMainOnlineVersion()
		{
			using (WebClient webClient = new WebClient())
			{
				using (Stream stream = webClient.OpenRead(url_version))
				{
					StreamReader reader = new StreamReader(stream);
					var v = reader.ReadToEnd();
					var version = v.Split(new string[] { "#", ":" }, StringSplitOptions.None);
					return version[1];
				}
			}
		}
		private void Download()
		{
			using (WebClient webClient = new WebClient())
			{
				if (!Directory.Exists(download_folder_path))
					Directory.CreateDirectory(download_folder_path);

				webClient.DownloadFile(url_donwload_file, download_file_path);

				using (Stream stream = webClient.OpenRead(url_version))
				{
					StreamReader reader = new StreamReader(stream);
					var info = (reader.ReadToEnd().Split(new string[] { "#" }, StringSplitOptions.None))[1];

					string i = download_folder_path + "//i.pikun";
					using (StreamWriter writer = new StreamWriter(i))
					{
						writer.WriteLine(info.Split(':')[1]);
					}

					string p = download_folder_path + "//p.pikun";
					using (StreamWriter writer = new StreamWriter(p))
					{
						writer.WriteLine("extract_path:" + extract_path);
					}
				}
			}

			//ZipFile.ExtractToDirectory(download_file_path, extract_path);

		}
		private void IsUpdateNewAutoUpdater()
		{
			using (WebClient webClient = new WebClient())
			{
				using (Stream stream = webClient.OpenRead(url_version))
				{
					StreamReader reader = new StreamReader(stream);
					var stream_txt = reader.ReadToEnd();
					var is_update = (stream_txt.Split(new string[] { "#" }, StringSplitOptions.None))[2];

					if(is_update.Split(':')[1] == "1")
					{
						// กรณีต้องการอัพเดทผ่าน github page ให้เป็น is_update:1 โดย WFA.AutoUpdater v. จะเปลี่ยน ณ ที่นี้
						// แล้วอัพเดท WFA.OCR ผ่าน bin folder ตามปกติแล้ว
						var autoupdate_v = ((stream_txt.Split(new string[] { "#" }, StringSplitOptions.None))[3]).Split(':')[1];
						FileVersionInfo local_v = GetMainInfo("WFA.AutoUpdater");

						if (local_v.FileVersion != autoupdate_v)
						{
							Application.Run(new NewsForm());
							return;
						}
					}

					Download();
					OpenCmdInstall();
				}
			}

			//ZipFile.ExtractToDirectory(download_file_path, extract_path);

		}
		private void OpenCmdInstall()
		{
			string install_path = download_folder_path + "\\CA.Install.exe";
			ProcessStartInfo startInfo = new ProcessStartInfo();
			File.Copy(extract_path + "CA.Install.exe", install_path, true);
			startInfo.FileName = install_path;
			Process.Start(startInfo);
		}
		#endregion
	}
}

