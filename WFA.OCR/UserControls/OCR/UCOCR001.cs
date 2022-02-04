﻿using System;
using System.Drawing;
using System.Windows.Forms;
using Helper;
using WFA.PlugIn;
using System.Diagnostics;
using WFA.OCR.Helper;
using UCControl.OCR;
using UtilityLib;
using System.Collections.Generic;
using HotkeyManagement;

namespace WFA.OCR.UserControls
{
	public partial class UCOCR001 : UserControl
	{

		#region init
		private OCRDA ocr = new OCRDA();

		public UCOCR001()
		{
			InitializeComponent();
			ComboBox.CheckForIllegalCrossThreadCalls = false;
		}
		private void UCOCR001_Load(object sender, EventArgs e)
		{
			BuildHotkeyDDL();
			BuildLanguageDDL();
			ReadHotkey();

			if (!btnSave.Enabled)
			{
				ddlHotkey.Enabled = false;
				PluginHelper.MassageBox("Info", "Before using for the first time, download the desired language.", ButtonType.OK);
			}
		}
		#endregion

		#region event	
		private void btnDownloadLanguage_Click(object sender, EventArgs e)
		{
			//download

			//bind ddl all lang
			//var da = new OCRDA();

			//da.DTO.Model.GenerateType = OCRGenerateType.GetLanguage;
			//da.DTO.Model.CONFIG_PATH = SessionHelper.SYS_TESSDATA_PATH;

			//var result = Generate(OCRGenerateType.GetLanguage, da);
			//if (!result.IS_RESULT)
			//{
			//	PluginHelper.MassageBox("Error", "Cann't Read file config.\r\nDescription: " + result.ERROR_MESSAGE, ButtonType.OK);
			//	return;
			//}
			//
			//EnabledDropDownList();

			//register hotkey
			//enabled btn save
			//clear lbl save
		}
		private void btnSave_Click(object sender, EventArgs e)
		{
			ClearGenerateStatus();

			using (WaitForm form = new WaitForm(SaveDropDown))
			{
				form.ShowDialog(this);
			}
		}
		private void ddlHotkey_SelectionChangeCommitted(object sender, EventArgs e)
		{
		}
		#endregion

		#region method        
		private ErrorResults Generate(string action, OCRDA da)
		{
			da.Generate(da.DTO);
			return da.DTO.ErrorResults;
		}
		private void ClearGenerateStatus()
		{
			lblDownloadStatus.Text = "";
			lblSaveStatus.Text = "";
		}
		private void EnabledDropDownList()
		{
			ddlHotkey.Enabled = true;
			ddlSourceLanguage.Enabled = true;
			ddlTargetLanguage.Enabled = true;
		}
		private void SaveDropDown()
		{
			var da = new OCRDA();

			da.DTO.Model.GenerateType = OCRGenerateType.SaveDropDown;
			da.DTO.Model.HOTKEY = ((DropDownList)ddlHotkey.Items[ddlHotkey.SelectedIndex]).VALUE;
			da.DTO.Model.SOURCE_LANG = ((DropDownList)ddlSourceLanguage.Items[ddlSourceLanguage.SelectedIndex]).VALUE;
			da.DTO.Model.TARGET_LANG = ((DropDownList)ddlTargetLanguage.Items[ddlTargetLanguage.SelectedIndex]).VALUE;

			da.DTO.Model.CONFIG_PATH = SessionHelper.SYS_CONFIG_PATH;
			da.DTO.Model.PATH = SessionHelper.SYS_PATH;

			var result = Generate(OCRGenerateType.SaveDropDown, da);
			if (!result.IS_RESULT)
			{
				PluginHelper.MassageBox("Error", "Cann't Save file config.\r\nDescription: " + result.ERROR_MESSAGE, ButtonType.OK);
				return;
			}

			//set hoekey
			MainForm.Instance.KCaptureArea = new LocalHotKey("KCaptureArea", da.DTO.Model.HOTKEY.KeyEmun());
			MainForm.Instance.MyHotKeyManager.RemoveLocalHotKey(MainForm.Instance.KCaptureArea);
			MainForm.Instance.MyHotKeyManager.AddLocalHotKey(MainForm.Instance.KCaptureArea);

			lblSaveStatus.Text = "Save Complete!";
		}
		private void ReadHotkey()
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
			ddlSourceLanguage.SelectedValue = da.DTO.Model.SOURCE_LANG;
			ddlTargetLanguage.SelectedValue = da.DTO.Model.TARGET_LANG;
		}
		private void BuildHotkeyDDL()
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
		private void BuildLanguageDDL()
		{
			var da = new OCRDA();
			da.DTO.Model.SOURCE_LANG_LIST = SessionHelper.SYS_SOU_LANGUAGE;
			da.DTO.Model.TARGET_LANG_LIST = SessionHelper.SYS_TAR_LANGUAGE;
			
			if (da.DTO.Model.SOURCE_LANG_LIST.Count > 0)
			{
				ddlSourceLanguage.ValueMember = "VALUE";
				ddlSourceLanguage.DisplayMember = "TEXT";
				ddlSourceLanguage.DataSource = da.DTO.Model.SOURCE_LANG_LIST;
				ddlSourceLanguage.SelectedIndex = 0;
			}
			else
			{
				btnSave.Enabled = false;
				ddlSourceLanguage.Enabled = false;
				lblSaveStatus.Text = "Error 404 Data not found!";
			}

			if (da.DTO.Model.TARGET_LANG_LIST.Count > 0)
			{
				ddlTargetLanguage.ValueMember = "VALUE";
				ddlTargetLanguage.DisplayMember = "TEXT";
				ddlTargetLanguage.DataSource = da.DTO.Model.TARGET_LANG_LIST;
				ddlTargetLanguage.SelectedIndex = 0;
			}
			else
			{
				btnSave.Enabled = false;
				ddlTargetLanguage.Enabled = false;
				lblSaveStatus.Text = "Error 404 Data not found!";
			}
		}



		#endregion

		
	}
}
