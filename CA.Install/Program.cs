using System;
using System.IO;
using System.IO.Compression;
using System.Runtime.InteropServices;

namespace CA.Install
{
	class Program
	{
		[DllImport("kernel32.dll")]
		private static extern IntPtr GetConsoleWindow();
		[DllImport("User32.dll")]
		private static extern bool ShowWindow(IntPtr hwnd, int cmdShow);

		static void Main(string[] args)
		{
			IntPtr hwnd = GetConsoleWindow();
			if (hwnd != IntPtr.Zero)
				ShowWindow(hwnd, 0);

			string extractPath = File.ReadAllText(Path.GetTempPath() + "WFA.OCR\\p.pikun").Split(new string[] { "extract_path:", "\r\n" }, StringSplitOptions.None)[1];
			string zipPath = AppDomain.CurrentDomain.BaseDirectory + "WFA.OCR.zip";

			var all_file = Directory.GetFiles(extractPath, "*");
			foreach (var item in all_file)
			{
				File.Delete(item);
			}

			ZipFile.ExtractToDirectory(zipPath, extractPath);
		}
	}
}
