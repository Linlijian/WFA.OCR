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
			return (ddl_lang().Split(new string[] { "\r\n" }, StringSplitOptions.None).Where(t=>t.Contains(txt+":"))).FirstOrDefault().Split(':').Last().IsNullOrEmpty()
				? null
				: (ddl_lang().Split(new string[] { "\r\n" }, StringSplitOptions.None).Where(t => t.Contains(txt + ":"))).FirstOrDefault().Split(':').Last();
		}
		private static void WriteFle(string _path)
		{
			using (StreamWriter writer = new StreamWriter(_path))
			{
				writer.WriteLine("Hotkey:");
				writer.WriteLine("SourceLanguage:");
				writer.WriteLine("TargetLanguage:");
			}
		}

		#region ddl
		private static string ddl_lang()
		{
			return		@"
							afr:Afrikaans
							amh:Amharic
							ara:Arabic
							asm:Assamese
							aze:Azerbaijani
							aze_cyrl:Azerbaijani - Cyrillic
							bel:Belarusian
							ben:Bengali
							bod:Tibetan
							bos:Bosnian
							bul:Bulgarian
							cat:Catalan; Valencian
							ceb:Cebuano
							ces:Czech
							chi_sim:Chinese - Simplified
							chi_tra:Chinese - Traditional
							chr:Cherokee
							cym:Welsh
							dan:Danish
							deu:German
							dzo:Dzongkha
							ell:Greek, Modern (1453-)
							eng:English
							enm:English, Middle (1100-1500)
							epo:Esperanto
							est:Estonian
							eus:Basque
							fas:Persian
							fin:Finnish
							fra:French
							frk:Frankish
							frm:French, Middle (ca. 1400-1600)
							gle:Irish
							glg:Galician
							grc:Greek, Ancient (-1453)
							guj:Gujarati
							hat:Haitian; Haitian Creole
							heb:Hebrew
							hin:Hindi
							hrv:Croatian
							hun:Hungarian
							iku:Inuktitut
							ind:Indonesian
							isl:Icelandic
							ita:Italian
							ita_old:Italian - Old
							jav:Javanese
							jpn:Japanese
							kan:Kannada
							kat:Georgian
							kat_old:Georgian - Old
							kaz:Kazakh
							khm:Central Khmer
							kir:Kirghiz; Kyrgyz
							kor:Korean
							kur:Kurdish
							lao:Lao
							lat:Latin
							lav:Latvian
							lit:Lithuanian
							mal:Malayalam
							mar:Marathi
							mkd:Macedonian
							mlt:Maltese
							msa:Malay
							mya:Burmese
							nep:Nepali
							nld:Dutch; Flemish
							nor:Norwegian
							ori:Oriya
							pan:Panjabi; Punjabi
							pol:Polish
							por:Portuguese
							pus:Pushto; Pashto
							ron:Romanian; Moldavian; Moldovan
							rus:Russian
							san:Sanskrit
							sin:Sinhala; Sinhalese
							slk:Slovak
							slv:Slovenian
							spa:Spanish; Castilian
							spa_old:Spanish; Castilian - Old
							sqi:Albanian
							srp:Serbian
							srp_latn:Serbian - Latin
							swa:Swahili
							swe:Swedish
							syr:Syriac
							tam:Tamil
							tel:Telugu
							tgk:Tajik
							tgl:Tagalog
							tha:Thai
							tir:Tigrinya
							tur:Turkish
							uig:Uighur; Uyghur
							ukr:Ukrainian
							urd:Urdu
							uzb:Uzbek
							uzb_cyrl:Uzbek - Cyrillic
							vie:Vietnamese
							yid:Yiddish
						";
		}
		#endregion

	}
}
