using System;
using System.Windows.Forms;
using WFA.PlugIn;
using WFA.OCR.Helper;
using UCControl.OCR;
using UtilityLib;

namespace WFA.OCR.UserControls
{
	public partial class UCOCRS01 : UserControl
	{
		#region init
		private OCRDA ocr = new OCRDA();

		public UCOCRS01()
		{
			InitializeComponent();
			ComboBox.CheckForIllegalCrossThreadCalls = false;
		}
		private void UCOCRS01_Load(object sender, EventArgs e)
		{
			BuildLanguageList();
		}
		#endregion

		#region event	
		private void btnDownloadLanguage_Click(object sender, EventArgs e)
		{
			ClearTemp();
			ClearGenerateStatus();

			using (WaitForm form = new WaitForm(DownloadFile))
			{
				form.ShowDialog(this);
			}
		}
		#endregion

		#region method        
		private ErrorResults Generate(OCRDA da)
		{
			da.Generate(da.DTO);
			return da.DTO.ErrorResults;
		}
		private void ClearGenerateStatus()
		{
			lblDownloadStatus.Text = "";
		}
		private void ClearTemp()
		{
			if(System.IO.Directory.Exists(System.IO.Path.GetTempPath() + "TessData"))
				System.IO.Directory.Delete(System.IO.Path.GetTempPath() + "TessData");
		}
		private void DownloadFile()
		{
			var da = new OCRDA();

			da.DTO.Model.GenerateType = OCRGenerateType.DownloadFile;
			da.DTO.Model.CLB_LANGUAGE_LIST = clb_LanguageList.CheckedItems;
			da.DTO.Model.CONFIG_PATH = SessionHelper.SYS_TESSDATA_PATH;
			da.DTO.Model.TEMP_PATH = System.IO.Path.GetTempPath() + "TessData";
			da.DTO.Model.TESS_PATH = AppDomain.CurrentDomain.BaseDirectory + "TessData";

			var result = Generate(da);
			if (!result.IS_RESULT)
			{
				ClearTemp();
				PluginHelper.MassageBox("Error", "Cann't Download file.\r\nDescription: " + result.ERROR_MESSAGE, ButtonType.OK);
				return;
			}

			SessionHelper.SYS_TAR_LANGUAGES = da.DTO.Model.TARGET_LANG_LIST;

			lblDownloadStatus.Text = "Download Compete!";
		}
		private void BuildLanguageList()
		{
			foreach (var item in SessionHelper.SYS_LINK_DOWNLOAD_V3)
			{
				clb_LanguageList.Items.Add(item.LANGUAGE_TEXT);
			}
		}
		#endregion
	}
}
