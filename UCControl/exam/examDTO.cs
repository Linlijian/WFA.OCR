using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityLib;

namespace UCControl.exam
{
	public class examDTO : GlobalDTO
	{
		public examDTO()
		{
			Model = new examModel();
		}

		public examModel Model { get; set; }
	}

	public class examGenerateType
	{
		public const string xxx = "xxx";
	}
}
