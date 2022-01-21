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
        public ResultList(List<Results> result)
        {
            InitializeComponent();
            this.resultGrid.DataSource = result;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
