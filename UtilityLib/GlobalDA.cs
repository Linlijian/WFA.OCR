using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityLib
{
	public abstract class GlobalDA
	{
		protected virtual GlobalDTO PKGenerate(GlobalDTO DTO)
		{
			return DTO;
		}

		/// <summary>
		/// สร้าวมาเพื่อเวลาเอาไปใช้ไม่ต้องใส่ try catch ทุกครั้ง
		/// </summary>
		/// <param name="DTO"></param>
		/// <returns></returns>
		public GlobalDTO Generate(GlobalDTO DTO)
		{
			try
			{
				DTO = PKGenerate(DTO);
			}
			catch (Exception ex)
			{
				DTO.ErrorResults.IS_RESULT = false;
				DTO.ErrorResults.ERROR_MESSAGE = ex.Message;
			}

			return DTO;
		}
	}
}
