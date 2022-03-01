using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA.OCR.FormControls
{
	public partial class testForm : Form
	{
		public testForm(string name)
		{
			InitializeComponent();
			this.Text = name;
		}
	}
}
