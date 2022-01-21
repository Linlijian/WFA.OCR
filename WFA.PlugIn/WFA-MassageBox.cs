using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilityLib;
using WFA.PlugIn;

namespace WFA.PlugIn
{
    public partial class MassageBox : Form
    {
        public MassageBox(MassageBoxModel model)
        {
            InitializeComponent();
            lblTitle.Text = model.TITLE;
            txtMessage.Text = model.MESSAGE;

            switch (model.BUTTON_TYPE)
            {
                case ButtonType.OK:
                    btnOK.Location = new Point(135, 134);
                    btnCancel.Visible = false;
                    break;
                case ButtonType.CANCEL:
                    btnCancel.Location = new Point(135, 134);
                    btnOK.Visible = false;
                    break;
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            SessionHelper.SYS_DIALOG_RESULT = true;
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            SessionHelper.SYS_DIALOG_RESULT = false;
            this.Close();
        }

        private void MassageBox_Load(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();

            //SystemSounds.Hand.Play();
            //SystemSounds.Beep.Play();
            //SystemSounds.Asterisk.Play();
            //SystemSounds.Exclamation.Play();
            //SystemSounds.Question.Play();
        }
    }
}
