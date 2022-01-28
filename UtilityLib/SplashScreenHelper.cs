using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UtilityLib
{
	public class SplashScreenHelper
	{
		public static string GetFile(string _path)
		{
			return Directory.GetFiles(_path, "*.pikun").IsNullOrEmpty() ? null : Directory.GetFiles(_path, "*.pikun").FirstOrDefault();
		}
		public static string CreateConfig(string _path, string _file_path)
		{
			try
			{
				if (Directory.Exists(_path))
				{
					WriteFle(_file_path);
				}
				else
				{
					CreateFolder(_path);
					WriteFle(_file_path);
				}

				return string.Empty;
			}
			catch (Exception e)
			{
				return e.Message;
			}
		}
		public static string CreateFile(string _file_path)
		{
			try
			{
				WriteFle(_file_path);

				return string.Empty;
			}
			catch (Exception e)
			{
				return e.Message;
			}
		}
		public static string[] ReadConfig(string _config)
		{
			return File.ReadAllText(_config).Split(new string[] { "\r\n" }, StringSplitOptions.None);
		}

		private static void CreateFolder(string _path)
		{
			Directory.CreateDirectory(_path);
		}
		private static void WriteFle(string _path)
		{
			using (StreamWriter writer = new StreamWriter(_path))
			{
				writer.WriteLine("Hotkey:F1");
				writer.WriteLine("test:test_text");
			}
		}
	}
}
