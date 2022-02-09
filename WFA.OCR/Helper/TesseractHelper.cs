﻿using Emgu.CV.OCR;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Net.Http;
using System.Collections;
using System.Web.Script.Serialization;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace Helper
{
	public class TesseractHelper
	{
		string image_apth;
		string trans_txt;
		string tess_txt;

		public TesseractHelper()
		{
			image_apth = Path.GetTempPath() + "CaptureImage.bmp";
		}
		public string GetTessText()
		{
			return tess_txt;
		}
		public string GetTransText()
		{
			return trans_txt;
		}

		public void Translate(string _path, string _souLang, string _tarLang, string _gooLang)
		{
			try
			{
				using (var image = new Image<Bgr, byte>(image_apth))
				{
					using (var tess = new Tesseract(_path, _tarLang, OcrEngineMode.LstmOnly))
					{
						tess.SetImage(image);
						tess_txt = tess.GetUTF8Text().TrimEnd();
						var ch = tess.GetCharacters();
						trans_txt = TranslateText(tess_txt, _gooLang, _souLang);
					}
				}
			}
			catch (Exception e)
			{
				tess_txt = e.Message;
				trans_txt = string.Empty;
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
		public static Bitmap CaptureImage(bool showCursor, Size curSize, Point curPos, Point SourcePoint, Point DestinationPoint, Rectangle SelectionRectangle)
		{
			using (Bitmap bitmap = new Bitmap(SelectionRectangle.Width, SelectionRectangle.Height))
			{
				using (Graphics g = Graphics.FromImage(bitmap))
				{
					g.CopyFromScreen(SourcePoint, DestinationPoint, SelectionRectangle.Size);
					bitmap.Save(Path.GetTempPath() + "CaptureImage.bmp", ImageFormat.Bmp);
				}

				return bitmap;
			}
		}
		public static void CaptureImage(bool showCursor, Size curSize, Point curPos, Point SourcePoint, Point DestinationPoint, Rectangle SelectionRectangle, string FilePath, string extension)
		{
			using (Bitmap bitmap = new Bitmap(SelectionRectangle.Width, SelectionRectangle.Height))
			{
				using (Graphics g = Graphics.FromImage(bitmap))
				{
					g.CopyFromScreen(SourcePoint, DestinationPoint, SelectionRectangle.Size);

					if (showCursor)
					{
						Rectangle cursorBounds = new Rectangle(curPos, curSize);
						Cursors.Default.Draw(g, cursorBounds);
					}
				}

				switch (extension)
				{
					case ".bmp":
						bitmap.Save(FilePath, ImageFormat.Bmp);
						break;
					case ".jpg":
						bitmap.Save(FilePath, ImageFormat.Jpeg);
						break;
					case ".gif":
						bitmap.Save(FilePath, ImageFormat.Gif);
						break;
					case ".tiff":
						bitmap.Save(FilePath, ImageFormat.Tiff);
						break;
					case ".png":
						bitmap.Save(FilePath, ImageFormat.Png);
						break;
					default:
						bitmap.Save(FilePath, ImageFormat.Jpeg);
						break;
				}
			}
		}
	}


}
