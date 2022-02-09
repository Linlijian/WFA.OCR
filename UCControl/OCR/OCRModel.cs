using System.Collections.Generic;
using UtilityLib;
using static System.Windows.Forms.CheckedListBox;

namespace UCControl.OCR
{
	public class OCRModel
	{
		public bool c1 { get; set; }
		public int c2 { get; set; }
		public string GenerateType { get; set; }
		public string HOTKEY { get; set; }
		public string TARGET_LANG { get; set; }
		public string SOURCE_LANG { get; set; }
		public string GOOGLE_LANG { get; set; }
		public string CONFIG_PATH { get; set; }
		public string TEMP_PATH { get; set; }
		public string TESS_PATH { get; set; }
		public string PATH { get; set; }

		public CheckedItemCollection CLB_LANGUAGE_LIST { get; set; }

		public List<DropDownList> SOURCE_LANG_LIST { get; set; }
		public List<DropDownList> TARGET_LANG_LIST { get; set; }

	}
}
