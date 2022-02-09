using System;
using System.Windows.Forms;
using UCControl.OCR;
using UtilityLib;

namespace WFA.OCR.UserControls
{
	public partial class UCABM001 : UserControl
	{
		#region init
		private OCRDA ocr = new OCRDA();

		public UCABM001()
		{
			InitializeComponent();
			ComboBox.CheckForIllegalCrossThreadCalls = false;
		}
		private void UCABM001_Load(object sender, EventArgs e)
		{
			pbProfileImage.Image = SessionHelper.ABM_PROFILE_IMAGE;
		}
		#endregion

		#region event	
		
		#endregion

		#region method        

		#endregion
	}
}
