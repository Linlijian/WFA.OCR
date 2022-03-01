using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCControl
{
	public class MSOfficeDA
	{
		public MSOfficeDTO DTO { get; set; }

		public MSOfficeDA()
		{
			DTO = new MSOfficeDTO();
		}
		public MSOfficeDTO Generate(MSOfficeDTO dto)
		{
			switch (dto.Model.GenerateType)
			{
				case MSOfficeGenerateType.xxx: return xxx(dto);
			}
			return dto;
		}

		public MSOfficeDTO xxx(MSOfficeDTO dto)
		{
			//do something

			return dto;
		}
	}
}
