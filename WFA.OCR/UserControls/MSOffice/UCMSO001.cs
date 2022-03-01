using System;
using System.Windows.Forms;
using UCControl;
using UCControl.OCR;
using UtilityLib;
using WFA.OCR.FormControls;

namespace WFA.OCR.UserControls
{
	public partial class UCMSO001 : UserControl
	{
		#region init
		private MSOfficeDA tempModel = new MSOfficeDA();

		public UCMSO001()
		{
			InitializeComponent();
			ComboBox.CheckForIllegalCrossThreadCalls = false;
		}
		private void UCMSO001_Load(object sender, EventArgs e)
		{
		}
		#endregion

		#region event	

		#endregion

		#region method        
		private ErrorResults Generate(MSOfficeDA da)
		{
			da.Generate(da.DTO);
			return da.DTO.ErrorResults;
		}
		private void ClearGenerateStatus()
		{

		}
		private bool CheckOpened(string name)
		{
			FormCollection fc = Application.OpenForms;

			foreach (Form frm in fc)
			{
				if (frm.Name == name)
				{
					return true;
				}
			}
			return false;
		}
		#endregion

		testForm test;
		private void button1_Click(object sender, EventArgs e)
		{
			if (CheckOpened("testForm"))
			{
				//update
				 test.Text = "update";
					test.Update();
			}else
			{
				//new
				test = new testForm("test show");
				test.Show();
			}
		}

		private void btnPreview_Click(object sender, EventArgs e)
		{
			if (CheckOpened("testForm"))
			{
				//update
				test.Text = "update";
				test.Update();
			}
			else
			{
				//new
				test = new testForm("test show");
				test.Show();
			}
		}
	}
}
