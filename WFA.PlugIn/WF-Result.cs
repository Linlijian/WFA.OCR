using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilityLib;

namespace WFA.PlugIn
{
    public partial class ResultList : Form
    {
		public ResultList(string _tar, string _sou)
        {
            InitializeComponent();

			txtSource.Text = _sou;
			txtTarget.Text = _tar;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		private void btnCopySource_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(txtSource.Text);
		}

		private void btnCopyTarGet_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(txtTarget.Text);
		}
	}
}
