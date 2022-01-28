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
			
			using (WaitForm form = new WaitForm(Generate))
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
		private void Generate()
		{
			var dto = new OCRDA();
			dto = ocr;

			try
			{
				dto.DTO.Model.GenerateType = OCRGenerateType.SaveHotkey;
				
				var a = (HotkeyDDL)ddlHotkey.Items[ddlHotkey.SelectedIndex];
				dto.DTO.Model.HOTKEY = a.TEXT;

				dto.DTO.Model.HOTKEY_PATH = SessionHelper.SYS_CONFIG_PATH;
				dto.DTO.Model.PATH = SessionHelper.SYS_PATH;
				dto.Generate(ocr.DTO);
			}
			catch (Exception ex)
			{
				ocr.DTO.ErrorResults.ERROR_CODE = -1;
				ocr.DTO.ErrorResults.ERROR_MESSAGE = ex.Message;
			}
		}
		private void SetDDL()
		{
			var dto = new OCRDA();
			dto = ocr;

			try
			{
				dto.DTO.Model.GenerateType = OCRGenerateType.GetDDL;
				dto.DTO.Model.HOTKEY_PATH = SessionHelper.SYS_CONFIG_PATH;
				dto.DTO.Model.PATH = SessionHelper.SYS_PATH;
				dto.Generate(ocr.DTO);

				ddlHotkey.SelectedValue = dto.DTO.Model.HOTKEY;
			}
			catch (Exception ex)
			{
				ocr.DTO.ErrorResults.ERROR_CODE = -1;
				ocr.DTO.ErrorResults.ERROR_MESSAGE = ex.Message;
			}
		}
		private void ClearGenerateStatus()
		{
			lblSaveStatus.Text = "";
		}
		private void BuildDDL()
		{
			List<HotkeyDDL> models = new List<HotkeyDDL>();
			for (int i = 1; i <= 12; i++)
			{
				models.Add(new HotkeyDDL { TEXT = "F" + i.ToString(), VALUE = "F" + i.ToString() });
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
