using System;
using System.Drawing;
using System.Windows.Forms;
using Helper;
using UCControl.exam;
using WFA.PlugIn;

namespace WFA.OCR.UserControls
{
	public partial class UCEXAM001 : UserControl
	{
		#region init
		private examDA exam = new examDA();

		public UCEXAM001()
		{
			InitializeComponent();
		}
		private void UCPDF2IMGF001_Load(object sender, EventArgs e)
		{
			btnDelete.Visible = false;
		}
		#endregion

		#region event
		private void btnAdd_Click(object sender, EventArgs e)
		{
			ClearGenerateStatus();
			
		}
		private void btnDelete_Click(object sender, EventArgs e)
		{
			ClearGenerateStatus();

			if (listboxImage.Items.Count == 0)
				btnDelete.Visible = false;
		}
		private void btnGenerate_Click(object sender, EventArgs e)
		{
			ClearGenerateStatus();

			using (WaitForm form = new WaitForm(Generate))
			{
				form.ShowDialog(this);
			}

			if (exam.DTO.ErrorResults.ERROR_CODE < 0)
			{
				var message = new MassageBoxModel();
				message.TITLE = "Error";
				message.MESSAGE = "Please re-check to Generate PDF.\r\nDescription: " + exam.DTO.ErrorResults.ERROR_MESSAGE;
				message.BUTTON_TYPE = ButtonType.OK;

				using (MassageBox box = new MassageBox(message))
				{
					box.ShowDialog(this);
				}

				return;
			}

			GenerateResult();
			lblGenerateStatus.Text = "Generate Complete!";
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
			lblGenerateStatus.Text = "";
		}
		private void GenerateResult()
		{
			var message = new MassageBoxModel();
			message.TITLE = "Info";
			message.MESSAGE = "Coomplete";
			message.BUTTON_TYPE = ButtonType.OK;

			using (MassageBox box = new MassageBox(message))
			{
				box.ShowDialog(this);
			}
		}
		#endregion
	}
}
