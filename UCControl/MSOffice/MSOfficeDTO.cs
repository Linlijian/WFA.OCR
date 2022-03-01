using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityLib;

namespace UCControl
{
	public class MSOfficeDTO : GlobalDTO
	{
		public MSOfficeDTO()
		{
			Model = new MSOfficeModel();
		}

		public MSOfficeModel Model { get; set; }
	}

	public class MSOfficeGenerateType
	{
		public const string xxx = "xxx";
	}
}
