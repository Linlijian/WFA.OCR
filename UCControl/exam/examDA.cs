using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCControl.exam
{
	public class examDA
	{
		public examDTO DTO { get; set; }

		public examDA()
		{
			DTO = new examDTO();
		}
		public examDTO Generate(examDTO dto)
		{
			switch (dto.Model.GenerateType)
			{
				case examGenerateType.xxx: return xxx(dto);
			}
			return dto;
		}

		public examDTO xxx(examDTO dto)
		{
			//do something

			return dto;
		}
	}
}
