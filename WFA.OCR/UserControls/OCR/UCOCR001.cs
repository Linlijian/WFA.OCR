using System;
using System.Drawing;
using System.Windows.Forms;
using Helper;
using WFA.PlugIn;
using System.Diagnostics;
using WFA.OCR.Helper;
using UCControl.OCR;

namespace WFA.OCR.UserControls
{
	public partial class UCOCR001 : UserControl
	{
		#region init
		private OCRDA ocr = new OCRDA();
		Overlay overly;

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
				ClearGenerateStatus();

				PluginHelper.MassageBox("Info", "Overlay is running.Please take your hotkey.", ButtonType.OK);
				lblStartStatus.Text = "Ok here we go!";

				overly = new Overlay(ddlProcessId.SelectedItem.ToString());
				overly.Show();
			}
			catch (Exception err)
			{
				PluginHelper.MassageBox("Error", err.Message, ButtonType.OK);
			}
		}
		private void ddlProcessId_SelectedIndexChanged(object sender, EventArgs e)
		{
			//lblProcesssId.Text = "Connect process id complete";
		}
		private void btnExitOverly_Click(object sender, EventArgs e)
		{
			ClearGenerateStatus();
			overly.Close();
		}
		private void btnReload_Click(object sender, EventArgs e)
		{
			try
			{
				ClearGenerateStatus();
				ddlProcessId.Items.Clear();
				BuildDDL();

				lblReloadStatus.Text = "Reload Complete!";
			}
			catch (Exception err)
			{
				PluginHelper.MassageBox("Error", err.Message, ButtonType.OK);
			}
		}
		#endregion

		#region method        
		private void Generate()
		{
			var dto = new OCRDA();
			dto = ocr;

			try
			{
				dto.DTO.Model.GenerateType = OCRGenerateType.xxx;
				dto.Generate(ocr.DTO);
				ocr.DTO.ErrorResults.ERROR_CODE = 0;
			}
			catch (Exception ex)
			{
				ocr.DTO.ErrorResults.ERROR_CODE = -1;
				ocr.DTO.ErrorResults.ERROR_MESSAGE = ex.Message;
			}
		}
		private void ClearGenerateStatus()
		{
			lblProcesssId.Text = "";
			lblStartStatus.Text = "";
			lblExitOverlyStatus.Text = "";
			lblReloadStatus.Text = "";
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
