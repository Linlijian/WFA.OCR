using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityLib;

namespace UCControl.OCR
{
	public class OCRDA
	{
		public OCRDTO DTO { get; set; }

		public OCRDA()
		{
			DTO = new OCRDTO();
		}
		public OCRDTO Generate(OCRDTO dto)
		{
			switch (dto.Model.GenerateType)
			{
				case OCRGenerateType.xxx: return xxx(dto);
				case OCRGenerateType.SaveHotkey: return SaveHotkey(dto);
				case OCRGenerateType.GetDDL: return GetDDL(dto);
			}
			return dto;
		}

		public OCRDTO xxx(OCRDTO dto)
		{
			//do something

			return dto;
		}
		public OCRDTO GetDDL(OCRDTO dto)
		{
			if (IsPathExist(dto.Model.PATH))
			{
				var config = SplashScreenHelper.ReadConfig(dto.Model.HOTKEY_PATH);
				dto.Model.HOTKEY = config.Where(x => x.Contains("Hotkey")).FirstOrDefault().Split(':').Last();
			}
			else
			{
				dto.ErrorResults.ERROR_CODE = -1;
				dto.ErrorResults.ERROR_MESSAGE = "Not found folder!";
			}

			return dto;
		}
		public OCRDTO SaveHotkey(OCRDTO dto)
		{
			if (IsPathExist(dto.Model.PATH))
			{
				var config = SplashScreenHelper.ReadConfig(dto.Model.HOTKEY_PATH);
				var arr = config.Where(x => x.Contains("Hotkey")).FirstOrDefault();
				string otkey = arr.Split(':').First() + ":" + dto.Model.HOTKEY;

				int i = 0;
				foreach (var item in config)
				{
					if (item.Equals(arr))
					{
						config[i] = otkey;
						break;
					}
					i++;
				}

				using (StreamWriter writer = new StreamWriter(dto.Model.HOTKEY_PATH))
				{
					foreach (var item in config)
					{
						if(!item.IsNullOrEmpty())
							writer.WriteLine(item);
					}
				}
			}
			else
			{
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
