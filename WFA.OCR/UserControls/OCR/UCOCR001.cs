using System;
using System.Drawing;
using System.Windows.Forms;
using Helper;
using UCControl.exam;
using WFA.PlugIn;
using System.Diagnostics;

namespace WFA.OCR.UserControls
{
	public partial class UCOCR001 : UserControl
	{
		#region init
		private examDA exam = new examDA();

		public UCOCR001()
		{
			InitializeComponent();
		}
		private void UCOCR001_Load(object sender, EventArgs e)
		{
			BuildDDL();
		}
		#endregion

		#region event
		private void btnStartTranslate_Click(object sender, EventArgs e)
		{
			try
			{
				// open overal
				GenerateResult("Info", "Overlay is running.Please take your hotkey.", ButtonType.OK);
				lblStartStatus.Text = "Ok here we go!";
			}
			catch (Exception)
			{
				
				throw;
			}
		}
		private void ddlProcessId_SelectedIndexChanged(object sender, EventArgs e)
		{
			//lblProcesssId.Text = "Connect process id complete";
		}
		#endregion

		#region method        
		private void Generate()
		{
			var dto = new examDA();
			dto = exam;

			try
			{
				dto.DTO.Model.GenerateType = examGenerateType.xxx;
				dto.Generate(exam.DTO);
				exam.DTO.ErrorResults.ERROR_CODE = 0;
			}
			catch (Exception ex)
			{
				exam.DTO.ErrorResults.ERROR_CODE = -1;
				exam.DTO.ErrorResults.ERROR_MESSAGE = ex.Message;
			}
		}
		private void ClearGenerateStatus()
		{
			lblProcesssId.Text = "";
			lblStartStatus.Text = "";
		}
		private void GenerateResult(string title, string text, string mode)
		{
			var message = new MassageBoxModel();
			message.TITLE = title;
			message.MESSAGE = text;
			message.BUTTON_TYPE = mode;

			using (MassageBox box = new MassageBox(message))
			{
				box.ShowDialog(this);
			}
		}
		private void BuildDDL()
		{
			Process[] processlist = Process.GetProcesses();
			foreach (Process theprocess in processlist)
			{
				if(!theprocess.MainWindowTitle.Equals(""))
					ddlProcessId.Items.Add(theprocess.MainWindowTitle);
			}

			if (ddlProcessId.Items.Count > 0)
			{
				ddlProcessId.SelectedText = processlist[0].MainWindowTitle;
				ddlProcessId.SelectedIndex = 0;
			}
			else
			{
				ddlProcessId.Items.Add("Process Not Found!");
				ddlProcessId.SelectedIndex = 0;
			}
		}
		#endregion
	}
}
