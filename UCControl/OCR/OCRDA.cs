using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
			}
			return dto;
		}

		public OCRDTO xxx(OCRDTO dto)
		{
			//do something

			return dto;
		}
	}
}
