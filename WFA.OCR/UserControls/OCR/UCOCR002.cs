using System;
using System.Drawing;
using System.Windows.Forms;
using Helper;
using WFA.PlugIn;
using System.Diagnostics;
using WFA.OCR.Helper;
using UCControl.OCR;
using UtilityLib;
using System.Collections.Generic;

namespace WFA.OCR.UserControls
{
	public partial class UCOCR002 : UserControl
	{
		#region init
		private OCRDA ocr = new OCRDA();

		public UCOCR002()
		{
			InitializeComponent();
		}
		private void UCOCR002_Load(object sender, EventArgs e)
		{
			BuildDDL();
			SetDDL();
			ComboBox.CheckForIllegalCrossThreadCalls = false;
		}
		#endregion

		#region event
		private void btnSaveHotkey_Click(object sender, EventArgs e)
		{
			ClearGenerateStatus();
			
			using (WaitForm form = new WaitForm(SaveHotkey))
			{
				form.ShowDialog(this);
			}

			if (ocr.DTO.ErrorResults.ERROR_CODE < 0)
			{
				PluginHelper.MassageBox("Error", "Cann't Save.\r\nDescription: " + ocr.DTO.ErrorResults.ERROR_MESSAGE, ButtonType.OK);
				return;
			}

			lblSaveStatus.Text = "Save Complete!";
		}
		#endregion

		#region method        
		private void SaveHotkey()
		{
			
		}
		private void SetDDL()
		{
			var da = new OCRDA();

			da.DTO.Model.GenerateType = OCRGenerateType.GetDDL;
			da.DTO.Model.CONFIG_PATH = SessionHelper.SYS_CONFIG_PATH;
			da.DTO.Model.PATH = SessionHelper.SYS_PATH;

			var result = Generate(OCRGenerateType.GetDDL, da);
			if (!result.IS_RESULT)
			{
				PluginHelper.MassageBox("Error", "Cann't Read file config.\r\nDescription: " + result.ERROR_MESSAGE, ButtonType.OK);
				return;
			}

			ddlHotkey.SelectedValue = da.DTO.Model.HOTKEY;
		}
		private void ClearGenerateStatus()
		{
			lblSaveStatus.Text = "";
		}
		private ErrorResults Generate(string action, OCRDA da)
		{
			switch (action)
			{
				case OCRGenerateType.GetDDL:
					da.Generate(da.DTO);
					break;
				

			}

			return da.DTO.ErrorResults;
		}
		private void BuildDDL()
		{
			List<DropDownList> models = new List<DropDownList>();
			for (int i = 1; i <= 12; i++)
			{
				models.Add(new DropDownList { TEXT = "F" + i.ToString(), VALUE = "F" + i.ToString() });
			}

			ddlHotkey.ValueMember = "VALUE";
			ddlHotkey.DisplayMember = "TEXT";
			ddlHotkey.DataSource = models;
			ddlHotkey.SelectedIndex = 0;
		}
		#endregion

		private void ddlHotkey_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
