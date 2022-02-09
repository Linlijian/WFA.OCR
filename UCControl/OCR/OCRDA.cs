using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using UtilityLib;

namespace UCControl.OCR
{
	public class OCRDA : GlobalDA
	{
		public OCRDTO DTO { get; set; }

		public OCRDA()
		{
			DTO = new OCRDTO();
		}
		protected override GlobalDTO PKGenerate(GlobalDTO globalDTO)
		{
			OCRDTO dto = (OCRDTO)globalDTO;
			switch (dto.Model.GenerateType)
			{
				case OCRGenerateType.xxx: return xxx(dto);
				case OCRGenerateType.SaveDropDown: return SaveDropDown(dto);
				case OCRGenerateType.GetDDL: return GetDDL(dto);
				case OCRGenerateType.GetLanguage: return GetLanguage(dto);
				case OCRGenerateType.DownloadFile: return DownloadFile(dto);
			}
			return dto;
		}

		public OCRDTO xxx(OCRDTO dto)
		{
			//do something

			return dto;
		}
		public OCRDTO DownloadFile(OCRDTO dto)
		{
			if (!IsPathExist(dto.Model.TEMP_PATH))
				Directory.CreateDirectory(dto.Model.TEMP_PATH);
			
			WebClient webClient = new WebClient();
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			foreach (var item in dto.Model.CLB_LANGUAGE_LIST)
			{
				var link = SessionHelper.SYS_LINK_DOWNLOAD_V41.Find(x => x.LANGUAGE_TEXT == item.ToString());
				var file_tar = dto.Model.TESS_PATH + "\\" + link.LANGUAGE_CODE;
				var file_sou = dto.Model.TEMP_PATH + "\\" + link.LANGUAGE_CODE;
				webClient.DownloadFile(link.LANGUAGE_LINK, file_sou);

				if (File.Exists(file_tar))
					File.Delete(file_tar);
				File.Move(file_sou, file_tar);
			}

			GetLanguage(dto);
			if (!dto.ErrorResults.IS_RESULT)
			{
				dto.ErrorResults.IS_RESULT = false;
				dto.ErrorResults.ERROR_CODE = -1;
				dto.ErrorResults.ERROR_MESSAGE = "Not found folder!";
			}

			return dto;
		}
		public OCRDTO GetLanguage(OCRDTO dto)
		{
			if (IsPathExist(dto.Model.CONFIG_PATH))
			{
				var config = IOHelper.ReadFolderTrainData(dto.Model.CONFIG_PATH);

				dto.Model.TARGET_LANG_LIST = new List<DropDownList>();
				foreach (var item in config)
				{
					dto.Model.TARGET_LANG_LIST.Add(new DropDownList { TEXT = IOHelper.GetTextLang(item), VALUE = item });
				}

				dto.ErrorResults.IS_RESULT = true;
			}
			else
			{
				dto.ErrorResults.IS_RESULT = false;
				dto.ErrorResults.ERROR_CODE = -1;
				dto.ErrorResults.ERROR_MESSAGE = "Not found folder!";
			}

			return dto;
		}
		public OCRDTO GetDDL(OCRDTO dto)
		{
			if (IsPathExist(dto.Model.PATH))
			{
				var config = IOHelper.ReadConfig(dto.Model.CONFIG_PATH);
				dto.Model.HOTKEY = config.Where(x => x.Contains("Hotkey")).FirstOrDefault().Split(':').Last();
				dto.Model.SOURCE_LANG = config.Where(x => x.Contains("SourceLanguage")).FirstOrDefault().Split(':').Last();
				dto.Model.TARGET_LANG = config.Where(x => x.Contains("TargetLanguage")).FirstOrDefault().Split(':').Last();
				dto.Model.GOOGLE_LANG = config.Where(x => x.Contains("GoogleLanguage")).FirstOrDefault().Split(':').Last();
				dto.ErrorResults.IS_RESULT = true;
			}
			else
			{
				dto.ErrorResults.IS_RESULT = false;
				dto.ErrorResults.ERROR_CODE = -1;
				dto.ErrorResults.ERROR_MESSAGE = "Not found folder!";
			}

			return dto;
		}
		public OCRDTO SaveDropDown(OCRDTO dto)
		{
			if (IsPathExist(dto.Model.PATH))
			{
				var config = IOHelper.ReadConfig(dto.Model.CONFIG_PATH);
				var item_list = new List<string>();

				item_list.Add((config.Where(x => x.Contains("Hotkey")).FirstOrDefault()).Split(':').First() + ":" + dto.Model.HOTKEY);
				item_list.Add((config.Where(x => x.Contains("SourceLanguage")).FirstOrDefault()).Split(':').First() + ":" + dto.Model.SOURCE_LANG);
				item_list.Add((config.Where(x => x.Contains("TargetLanguage")).FirstOrDefault()).Split(':').First() + ":" + dto.Model.TARGET_LANG);
				item_list.Add((config.Where(x => x.Contains("GoogleLanguage")).FirstOrDefault()).Split(':').First() + ":" + dto.Model.GOOGLE_LANG);

				int i = 0;
				foreach (var item in config)
				{
					foreach (var lang in item_list)
					{
						if (item.Contains(lang.Split(':').First()))
						{
							config[i] = lang;
							break;
						}
					}
					i++;
				}

				using (StreamWriter writer = new StreamWriter(dto.Model.CONFIG_PATH))
				{
					foreach (var item in config)
					{
						if(!item.IsNullOrEmpty())
							writer.WriteLine(item);
					}
				}
				dto.ErrorResults.IS_RESULT = true;
			}
			else
			{
				dto.ErrorResults.IS_RESULT = false;
				dto.ErrorResults.ERROR_CODE = -1;
				dto.ErrorResults.ERROR_MESSAGE = "Not found folder!";
			}

			return dto;
		}

		private bool IsPathExist(string path)
		{
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
				return false;
			}

			return true;
		}
	}
}
