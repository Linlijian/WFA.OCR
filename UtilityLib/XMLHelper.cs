using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace UtilityLib
{
    public class XMLHelper
    {
        public FormState STATE;
        public FormState Model;
        public string ERROR { get; set; }

        public XMLHelper()
        {
            STATE = new FormState();
            Model = new FormState();
            ERROR = string.Empty;
        }

        public void loadConfig()
        {
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "config.xml";            
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(FormState));
                using (FileStream fs = File.OpenRead("config.xml"))
                {
                    STATE = (FormState)ser.Deserialize(fs);
                }
            }
            catch(Exception c)
            {
                XmlWriterSettings xmlWriterSettings = new XmlWriterSettings()
                {
                    Indent = true,
                    IndentChars = "\t",
                    NewLineOnAttributes = true
                };
                using (XmlWriter writer = XmlWriter.Create("config.xml", xmlWriterSettings))
                {
                    writer.WriteStartElement("FormState");
                    writer.WriteElementString("FolderIntput", @"C:\");
                    writer.WriteElementString("FolderOutput", @"C:\Generate");
                    writer.WriteElementString("CaseSelect", @"\d{6,8}_0x1010(_)(.*)[a-zA-Z][-._](\d{1,2})0x1010(_)(.*)[a-zA-Z](_)");
                    writer.WriteElementString("DupFile", "0");
                    writer.WriteEndElement();
                    writer.Flush();
                }
            }
        }

        public void writeConfig(FormState state)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("config.xml"))
                {
                    STATE = state;
                    XmlSerializer ser = new XmlSerializer(typeof(FormState));
                    ser.Serialize(sw, STATE);
                }
            }
            catch(Exception e) { ERROR = "Can't save config: " + e.Message; }
            
        }

        public void MergeConfig()
        {
            STATE.MergeState(Model);
        }

        public bool IsComplete()
        {
            return ERROR.IsNullOrEmpty() ? true : false;
        }
    }
}
