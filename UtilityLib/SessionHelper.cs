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
    }
}
