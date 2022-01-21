using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilityLib;
using WFA.PlugIn;

namespace WFA.PlugIn
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            VerifyStartUp();
        }
        private void VerifyStartUp()
        {
            //load xml
            lblStatus.Text = "Load Config";
            var xml = new XMLHelper();
            xml.loadConfig();

            //check folder output
            //เราไม่ต้องสร้างใหม่ ให้หามาเองหรือโหลดจาก git แบบ auto ถ้ามันหายไป
            //เราจะได้ตัดปัญหาการหาไม่เจอ
            //change icon all plug in

            //check dll ทุกอย่างจะได้ไม่ error เรื่อยๆ
            lblStatus.Text = "Folder Output";
            try
            {
                if (!xml.STATE.FolderOutput.IsNullOrEmpty())
                {
                    if (!Directory.Exists(xml.STATE.FolderOutput))
                    {
                        var state = new FormState();
                        state.FolderOutput = @"C:\Generate\";
                        Directory.CreateDirectory(state.FolderOutput);

                        xml.writeConfig(xml.STATE);
                    }
                }
                else
                {
                    SessionHelper.SYS_START_UP = false;
                    SessionHelper.SYS_ERROR_CODE = "003";
                    SessionHelper.SYS_ERROR_MESSAGE = "Can't create config. if first runing please Restart!";
                    SessionHelper.SYS_TITLE = "Infomation";

                    return;
                }
                
            }
            catch (Exception x)
            {
                SessionHelper.SYS_START_UP = false;
                SessionHelper.SYS_ERROR_CODE = "001";
                SessionHelper.SYS_ERROR_MESSAGE = "Can't Create Folder Output!";
                SessionHelper.SYS_TITLE = "ERROR";

                return;
            }

            lblStatus.Text = "Load Session";
            xml.loadConfig();

            try
            {
                var load_data = xml;
                SessionHelper.XML_FOLDER_INPUT = load_data.STATE.FolderIntput;
                SessionHelper.XML_FOLDER_OUTPUT = load_data.STATE.FolderOutput;
                SessionHelper.XML_CASE_SELECT = load_data.STATE.CaseSelect;
                SessionHelper.XML_DUP_FILE = load_data.STATE.DupFile;
            }
            catch (Exception x)
            {
                SessionHelper.SYS_START_UP = false;
                SessionHelper.SYS_ERROR_CODE = "002";
                SessionHelper.SYS_ERROR_MESSAGE = "Can't Load config in Session";
                SessionHelper.SYS_TITLE = "ERROR";

                return;
            }

            SessionHelper.SYS_START_UP = true;
        }

    }
}
