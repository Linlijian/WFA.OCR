using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace UtilityLib
{
	public class IOHelper
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
		public static string[] ReadFolder(string _path)
		{
			return Directory.GetFiles(_path, "*.traineddata").IsNullOrEmpty() ? null : Directory.GetFiles(_path, "*.traineddata");
		}
		public static string[] ReadFolderTrainData(string _path)
		{
			Regex regex = new Regex("[a-zA-Z]*.traineddata");
			var file = new List<string>();

			int i = 0;
			foreach (var item in ReadFolder(_path))
			{
				if (regex.IsMatch(item))
				{
					file.Add((regex.Match(item).Value).Split('.').First());
				}
			}
			return file.ToArray();
		}
		public static void CreateFolder(string _path)
		{
			Directory.CreateDirectory(_path);
		}
		public static string GetTextLang(string txt)
		{
			string text = SessionHelper.SYS_GOOGLE_LANGUAGES.Split(new string[] { "\r\n", ";" }, StringSplitOptions.None).Where(t => t.Contains(":" + txt)).FirstOrDefault();

			if (text.IsNullOrEmpty())
			{
				return string.Empty;
			}

			return text.Split(':').First();
		}
		public static string GetCodeLang(string txt, List<DropDownList> tar)
		{


			return string.Empty;
		}
		private static void WriteFle(string _path)
		{
			using (StreamWriter writer = new StreamWriter(_path))
			{
				writer.WriteLine("Hotkey:");
				writer.WriteLine("SourceLanguage:");
				writer.WriteLine("TargetLanguage:");
				writer.WriteLine("GoogleLanguage:");
			}
		}
	}
}
