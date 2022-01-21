using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA.PlugIn
{
    public class MassageBoxModel
    {
        public string TITLE { get; set; }
        public string MESSAGE { get; set; }
        public string BUTTON_TYPE { get; set; }
    }

    public static class ButtonType
    {
        public const string OK = "OK";
        public const string CANCEL = "CANCEL";
        public const string OK_CANCEL = "OK_CANCEL";
    }
        
}
