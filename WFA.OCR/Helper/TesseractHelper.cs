using Emgu.CV.OCR;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Net.Http;
using System.Collections;
using System.Web.Script.Serialization;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Helper
{
	public class TesseractHelper
	{
		public void Translate(Image _image, string _path, string _language)
		{
			Bitmap screen_image = (Bitmap)_image;
			using (var image = new Image<Bgr, byte>(screen_image))
			{
				using (var tess = new Tesseract(_path, _language, OcrEngineMode.TesseractLstmCombined))
				{
					tess.SetImage(image);
					var text = tess.GetUTF8Text().TrimEnd();
					var ch = tess.GetCharacters();
					string trans = TranslateText("Hello", "en", "ja");
				}
			}
		}

		private string TranslateText(string text, string trans_from, string trans_to)
		{
			string url = String.Format
			("https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}",
			 trans_from, trans_to, Uri.EscapeUriString(text));

			HttpClient httpClient = new HttpClient();
			string result = httpClient.GetStringAsync(url).Result;

			var jsonData = new JavaScriptSerializer().Deserialize<List<dynamic>>(result);
			var translationItems = jsonData[0];
			string translation = "";

			foreach (object item in translationItems)
			{
				IEnumerable translationLineObject = item as IEnumerable;
				IEnumerator translationLineString = translationLineObject.GetEnumerator();
				translationLineString.MoveNext();
				translation += string.Format(" {0}", Convert.ToString(translationLineString.Current));
			}

			if (translation.Length > 1) { translation = translation.Substring(1); };

			return translation;
		}
	}


}
