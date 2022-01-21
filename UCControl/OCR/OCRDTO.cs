using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityLib;

namespace UCControl.OCR
{
	public class OCRDTO : GlobalDTO
	{
		public OCRDTO()
		{
			Model = new OCRModel();
		}

		public OCRModel Model { get; set; }
	}

	public class OCRGenerateType
	{
		public const string xxx = "xxx";
	}
}
