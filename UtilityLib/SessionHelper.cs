using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityLib
{
    public class SessionHelper
    {
        /// <summary>
        /// Session control start program
        /// if return true = can start
        /// else return false = cant statrt because something of lose.
        /// </summary>
        public static bool SYS_START_UP;

        /// <summary>
        /// Session rerturn result opendialog.
        /// True = press OK.
        /// False = press Cancel.
        /// </summary>
        public static bool SYS_DIALOG_RESULT;

        public static string SYS_ERROR_MESSAGE;
        public static string SYS_TITLE;
        public static string SYS_ERROR_CODE;

        public static string XML_FOLDER_INPUT;
        public static string XML_FOLDER_OUTPUT;
        public static string XML_CASE_SELECT;
        public static string XML_DUP_FILE;


		//public static string TRANS_PATHDATA;
		//public static string TRANS_LANGUAGE_FROM;
		//public static string TRANS_LANGUAGE_TO;
		//public static string TRANS_LANGUAGE;

		public static List<DropDownList> SYS_SOU_LANGUAGE;
		public static List<DropDownList> SYS_TAR_LANGUAGE;
		public static string SYS_HOTKEY;
		public static string SYS_CONFIG_PATH
		{
			get {
				return SYS_PATH + "\\Config.pikun";
			}
		}
		public static string SYS_PATH
		{
			get
			{
				return AppDomain.CurrentDomain.BaseDirectory + "Config";
			}
		}
		public static string SYS_TESSDATA_PATH
		{
			get
			{
				return AppDomain.CurrentDomain.BaseDirectory + "TessData";
			}
		}

	}
}
