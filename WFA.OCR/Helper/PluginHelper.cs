using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA.PlugIn;

namespace WFA.OCR.Helper
{
	public class PluginHelper
	{
		public static void MassageBox(string title, string text, string mode)
		{
			var message = new MassageBoxModel();
			message.TITLE = title;
			message.MESSAGE = text;
			message.BUTTON_TYPE = mode;

			using (MassageBox box = new MassageBox(message))
			{
				box.ShowDialog();
			}
		}
	}
}
