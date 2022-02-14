using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilityLib;
using WFA.PlugIn;

namespace WFA.PlugIn
{
    public partial class SplashScreen : Form
    {
		#region init
		public Action Worker { get; set; }
		public SplashScreen(Action _worker)
		{
			InitializeComponent();
			VerifyStartUp();
			if (_worker == null)
				throw new ArgumentNullException();
			Worker = _worker;
		}
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			Task.Factory.StartNew(Worker).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
		}
		#endregion

		#region method
		private void VerifyStartUp()
		{
			try
			{
				#region load .pikun
				lblStatus.Text = "Load Config";

				if (Directory.Exists(SessionHelper.SYS_PATH))
				{
					if (!ReadConfig()) return;
				}
				else
				{
					lblStatus.Text = "Create Folder Config";
					string result = IOHelper.CreateConfig(SessionHelper.SYS_PATH, SessionHelper.SYS_CONFIG_PATH);
					if (!result.IsNullOrEmpty())
					{
						SetError(result, "000", "Fail");
						return;
					}

					//read file
					if (!ReadConfig()) return;
				}
				#endregion

				#region load ddl
				lblStatus.Text = "Load DropdownList from Tessdata";
				if (Directory.Exists(SessionHelper.SYS_TESSDATA_PATH))
				{
					var config = IOHelper.ReadFolderTrainData(SessionHelper.SYS_TESSDATA_PATH);
					var sou_lang = new List<DropDownList>();
					var tar_lang = new List<DropDownList>();

					foreach (var item in config)
					{
						tar_lang.Add(new DropDownList { TEXT = IOHelper.GetTextLang(item), VALUE = item });
					}
					SessionHelper.SYS_TAR_LANGUAGES = tar_lang;

					foreach (var item in SessionHelper.SYS_GOOGLE_LANGUAGES.Split(new string[] { "\r\n", ";" }, StringSplitOptions.None))
					{
						if (!item.IsNullOrEmpty())
						{
							var values = item.Split(':');
							sou_lang.Add(new DropDownList
							{
								TEXT = values[0],
								VALUE = values[1],
								REMARK = values[2]
							});
						}
					}

					SessionHelper.SYS_SOU_LANGUAGES = sou_lang.Where(s => !s.REMARK.IsNullOrEmpty()).ToList();
				}
				else
				{
					SetError(lblStatus.Text, "000", "Fail");
					return;
				}
				#endregion

				#region load file tassdata
				lblStatus.Text = "Load TainData from Tessdata";
				if (!Directory.Exists(SessionHelper.SYS_TESSDATA_PATH))
				{
					SetError(lblStatus.Text, "000", "Fail");
					return;
				}
				#endregion

				#region load download list
				lblStatus.Text = "Load Download language list ver.4.0";

				string link3 = @"https://github.com/tesseract-ocr/tessdata/raw/3.04.00/";
				string link4 = @"https://github.com/tesseract-ocr/tessdata/raw/4.00/";
				string link41 = @"https://github.com/tesseract-ocr/tessdata/raw/4.1.0/";

				List<DownloadLanguageLink> list3 = new List<DownloadLanguageLink>();
				List<DownloadLanguageLink> list4 = new List<DownloadLanguageLink>();
				List<DownloadLanguageLink> list41 = new List<DownloadLanguageLink>();

				foreach (var item in SessionHelper.LANG_DOWNLOAD.Split(new string[] { "\r\n" }, StringSplitOptions.None))
				{
					if (!item.IsNullOrEmpty())
					{
						var text = SessionHelper.SYS_SOU_LANGUAGES.Where(w => w.REMARK == item.Split('.').First()).FirstOrDefault().TEXT;
						list3.Add(new DownloadLanguageLink()
						{
							LANGUAGE_CODE = item,
							LANGUAGE_LINK = link3 + item,
							LANGUAGE_TEXT = text
						});
						list4.Add(new DownloadLanguageLink()
						{
							LANGUAGE_CODE = item,
							LANGUAGE_LINK = link4 + item,
							LANGUAGE_TEXT = text
						});
						list41.Add(new DownloadLanguageLink()
						{
							LANGUAGE_CODE = item,
							LANGUAGE_LINK = link41 + item,
							LANGUAGE_TEXT = text
						});
					}
				}

				SessionHelper.SYS_LINK_DOWNLOAD_V3 = list3;
				SessionHelper.SYS_LINK_DOWNLOAD_V4 = list4;
				SessionHelper.SYS_LINK_DOWNLOAD_V41 = list41;
				#endregion

				#region load profile image
				lblStatus.Text = "Load Profile image";
				string base64image = @"/9j/2wCEAAgGBgcGBQgHBwcJCQgKDBQNDAsLDBkSEw8UHRofHh0aHBwgJC4nICIsIxwcKDcpLDAxNDQ0Hyc5PTgyPC4zNDIBCQkJDAsMGA0NGDIhHCEyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMv/AABEIAPgA+AMBIgACEQEDEQH/xAGiAAABBQEBAQEBAQAAAAAAAAAAAQIDBAUGBwgJCgsQAAIBAwMCBAMFBQQEAAABfQECAwAEEQUSITFBBhNRYQcicRQygZGhCCNCscEVUtHwJDNicoIJChYXGBkaJSYnKCkqNDU2Nzg5OkNERUZHSElKU1RVVldYWVpjZGVmZ2hpanN0dXZ3eHl6g4SFhoeIiYqSk5SVlpeYmZqio6Slpqeoqaqys7S1tre4ubrCw8TFxsfIycrS09TV1tfY2drh4uPk5ebn6Onq8fLz9PX29/j5+gEAAwEBAQEBAQEBAQAAAAAAAAECAwQFBgcICQoLEQACAQIEBAMEBwUEBAABAncAAQIDEQQFITEGEkFRB2FxEyIygQgUQpGhscEJIzNS8BVictEKFiQ04SXxFxgZGiYnKCkqNTY3ODk6Q0RFRkdISUpTVFVWV1hZWmNkZWZnaGlqc3R1dnd4eXqCg4SFhoeIiYqSk5SVlpeYmZqio6Slpqeoqaqys7S1tre4ubrCw8TFxsfIycrS09TV1tfY2dri4+Tl5ufo6ery8/T19vf4+fr/2gAMAwEAAhEDEQA/APXf+ED8Kf8AQAsP+/Qo/wCED8Kf9ACw/wC/QroqKAOd/wCED8Kf9ACw/wC/Qo/4QPwp/wBACw/79CuiooA53/hA/Cn/AEALD/v0KP8AhA/Cn/QAsP8Av0K6KigDnf8AhA/Cn/QAsP8Av0KP+ED8Kf8AQAsP+/QroqKAOd/4QPwp/wBACw/79Cj/AIQPwp/0ALD/AL9CuiooA53/AIQPwp/0ALD/AL9Cj/hA/Cn/AEALD/v0K6KigDnf+ED8Kf8AQAsP+/Qo/wCED8Kf9ACw/wC/QroqKAOd/wCED8Kf9ACw/wC/Qo/4QPwp/wBACw/79CuiooA53/hA/Cn/AEALD/v0KP8AhA/Cn/QAsP8Av0K6KigDnf8AhA/Cn/QAsP8Av0KP+ED8Kf8AQAsP+/Qros0UAc7/AMIH4U/6AFh/36FH/CB+FP8AoAWH/foV0VFAHO/8IH4U/wCgBYf9+hR/wgfhT/oAWH/foV0VFAHO/wDCB+FP+gBYf9+hR/wgfhT/AKAFh/36FdFRQBzv/CB+FP8AoAWH/foUf8IH4UP/ADALD/v0K6KigDnf+ED8Kf8AQAsP+/Qo/wCED8Kf9ACw/wC/QroqKAOcPgPwp/0ALD/v0KP+EC8Kf9ACw/79CujooAKKKKACiiigAooooAKKKKACiiigBDRmk9gKgmuooPvtluyjkn8KAJyaRnVBlmAHuaoNPcy8gCBD3PLflTBBExzIDK3q5qXJIpJssPqNupwr+Yf9gZpBfOxIS1k+p4qMcDAAA9AKXJx1qPaor2Y77VcDk2w/775o/tB162sv4c02jJHel7YPZki6jbtwzFD/ALa4qyrhhlSCPUGqR+YYOCPcVGIUVt0bGFvVO9UqqYnTaNSlFRI4KcsOByacjhxuU5BrQgfRSCloAKKKKACiiigAooooAKKKKACiiigAooooAKKKKACiig0AFRu4VCzEBR1J7UyeeO3iMsjYUfrWeQ92RLcgBBykHb6t60m0hpXHvdTXP+o/dwk/61up+gpqIkRJQHd3Zjyae7E9aaBzWMptmsYC8k5PWn4pBSmsblhiiiigAoxRmkJoAXFHekzSE0AOViucH/69RhmtW82P5oz99B1X3FOpQcMDx+NXCdtyZRutC/G6yIHQgqehFOFZUcgspRj/AI9pDgj+43t7Vpr07V0J31MLWH0UUVQBRRRQAUUUUAFFFFABRRRQAUUUUAFFFFACE0ySRY0Z3OFUZJ9Ke1Z1z/pl0LYE+VH80p9fahgiKMNeSi6lX5B/qUPQe9TNnvUpHbAAHAHpUbDmsJ6msCLFFPxzRWbNGA6UtApDUgBOKM8UZpDSCwE0UhNJmgdh3agjimE0oai4WHYpRxxikzSj60IVg2LIjROoKPwwqTT5WMbwSH97CdpPqOxqPn1/GmFvKvrecfdl/dP9eoropS6GdRGrRSDoKWtjIKKKKACiiigAooooAKKKKACiiigAoopDQBFNKI4yx65wBUUMC20RAJJY7iT3NRyETX6R/wAMQ3H69qs7gy5pMaIsd6YwqQ/Slx8prJo0TIMUYqXHFG2s7DuRYoqUrgZqI9KTRSdxtNzmnGmE1LKQNTe1DGm1BY6jODTc0ZouFh+aM00Gk3UxWJAaLuMyWEmzl1+ZR7jkUwNVmD5wwPKkYI/z+Na09zOa0LMEomgjlXo6hhU1Z+lN/ohiP3oXZD+eR+hFaArqOcKKKKACiiigAooooAKKKKACiiigApvA5NKaiuG2QO3opIoYIzUl8u3nnzhnYn8BU8Moa2j55PNZV65j09UzyUJ/M1aic+WnHRR/KsZSNowurmmBgil/5Z/jVTz/AJGb+6pqSCXzLSN/WknoS42Je9JikDgvUnGDQgYP0FROOalcZNNFDQIgaoieamfqeKhKkjNZM2iNamZpxzTCazNUKWpu6mM1M3UhkuaQmmA5pN2TVCZMpq7aE7iO2KoJgsB71oRbVkG3rtNa0zGewyxO2+vYuwdX/EjH9K0R0rPtcf2pe49E/rWgOldSOZi0UUUAFFFFABRRRQAUUUUAFFFFACE4qpqLbbGT/aG0fjVyqGq/8eJ/3l/nSewLcw9ZLBNi9dqrVxV2qo9FH8qgv4vMuJMg4VS35VZVQY1I/uj+VcszqhqMkm2QSe6Gn6XcedpFs+epqpd5+zyjnGw5/I1DpL+XZmLPCPkURloVKBsCcAEd89acJgeCaoh/alV8HOaFIThoa5cKy/SkRgzcVReY7h9KfHMd45p81yHAnmOO1Rlh5eB3pLiUbEqv5vyDPrUtlRiyQjbxUTmnLJkke1Qu3NZs0ihyoZHABqLPzY75xSBzGcr1qPzPm3D7wOaV0XZk4G1XB9KYpBI5qaVw1uW7kVSyQaG7CSLYk/ecDtViBzlSTWejVbt2y4BPGRVQldkzjoXLP/kK3/8AwD+taI6VnaXh5L2TuZiv4bR/jWiK7o7HE9xaKKKYgooooAKKKKACiiigAooooAQ1R1Y4sGI6hl/nV+qeqLusJPbB/Wk9gW5lzKzTXRHRYT/Op41/dJ/uj+VNth5kl+x6GMD8hS2zBrSI/wCyK56uiN4PUztQZxGViIDuwQFugzRa2z2tzNC7AnarZHfFLqERmglTv1X2I6U63l864t5GOWlgKk+4NZR2NnuK/wAmB+NOXkZ9aJ8bgexplmSyyBuqOQPpgVFzSw7dinrLtdc9DUMg2vj0qMtS5h8tyy8+5APSo/MqDdShqTkPlsTiSkL5qHfijdmpuOw8mm5pM8UmaVx20J2YfZVFQZ96ak/mxKemOKMj0xRcEiRTzVmJ9p3Ht39P84qopAGe1LPL5VlNJ/dUn+n9auG6Jnsbmir/AMSxJD1kZnJ9ck4/TFaI6VXsovIsreH/AJ5xqv5AVZr0lsea9wooopiCiiigAooooAKKKKACiiigAqG6TzLeRPVSKmpGAPBoAx9JAkiuweMttz+GKZan/Rk4+6Cv61Loq7WvUPacioYcKsqDpHIRWNZaGlN6lS5OCxqrYyBbfTZAOS7p+dWdRJSORueFzWBFeta29vA6MUSVZFdR0UnBFcsHodsldHRy98/wsRUdjn7Vcoe4VqdOcSOM5yajtGxqpH96ID9TUMOhYuI+9VCOa0LgfKP1qiw5qWVEjIpKkxTcVNy0No70GigoWmSnCMfRSaeKhum22spHUKaBDLM5tYz6jNT1FbrttYl/2RUvahjRFcnFrKf9n+tSS5lW2gX70sqqPp1NEkfm28i+qH/Gk0v/AEnWdOUj5VjaUn3xxWtJXkjCs/dOyFOFNFOr0jzgooooAKKKKACiiigAooooAKKKKACkPUUtIetAGfYxlLi8PGGkB/SoJFC31yvTIVsf5+lXoxi6mHqAaq3a41OP/ppGy/lz/WoqK8SovVGdqCBonHYqRXITXBj0+5dW2lIQfwD12d3zH+OK4a6T/R9Qi54gZfryDXBFWPQXwnXM4dlkU5V0DCmRHGpwN/ssP5VDZyGXSdPn24ym0/hVgYE9swPAk/oal7i6GjIMxmqPBrRIzkVnP8sjD3qWEQ25ppFP7U01JZE1IOlOY803tSLQmear3z7bOT34qZqpXcm+zx/ekApoZdQbY1X0A/lTwM01Tzg9qnRcsKGxMNuAR6qR+hpvhmI/2lK+OI7ZYz9Sc1KrAXMQP94VL4YXEt+3q6V14ZXOSu7I6If1pwpB0pa7TjCiiigAooooAKKKKACiiigAooooAKQ0tFAEflgSl8nOMVS1P5FgnHPlyAn+X9a0ar3kXn2ssX95SPx7UnqmCdmZV2g2OB0zxXEXi4u7uMfeeJ8fkK7nPnWsbkHJXB+o4rjtTQxal5hGFYFM/Uf/AFq86WkrHfSleJd8Py/aNAZCcmIjHsMCrUz7ViPpKh/UVk+FJPsty9q3Cyp/48vP8mq/qS+VDMmeFGR7c1ElZmkVdHRg/rVO5XbJmn204liU9SQOafMu5PpUslaMrKOaGFOAoYVBaKrnijGVzRJ1oUfu6LlkbHFZUjZihXPW5P8AOtN8A1j7ubZfWZ6aGbKfe/E1diXJrPj5IrREgijVsdwKnqKZGc+bn3xVrw38tzqcf/POZV/SomjA9sn+oq3okHkXepndkyTBv0x/Su3CnFiDaFLSDpS13HKFFFFABRRRQAUUUUAFFFFABRRRQAUUUUAFI3HNLRQBkbPLluIOwPmL9D/k1yviGPYAw6o3H5V2V6BHPDMfu/cf6HpXOeJLfbbuem0hs/SuSvD3kzqoSsjFRGSQiIbXjSGeMjrkrg/y/Wtedlv7T7RFwJFwy/3T6VSijM0tuyHGLMZ/ByKq6bLcWl3c3O0mxkmKSqeoI6EVjOLZspqxq6ZMTZx5+8nyn8K2UkDpWWlqYJZGiIMMvzAjpViNyrgmsHuaP3tSwRg/jSEU8nPNNNSIpzjk0J/qW+tOuOtNi+69S2WtivJ94isIHM1qP+mj/wA63X+8a59Tultz6TP/ADqlsWjeiH3auXZ22MjY6L+XIqrEPu1euR/objrlG4/ChEzHROJNhJzkZz+FaFgQmp3anq6Rv+A4rG01s28B9UGKlu5rq21e1lt5EUyQspVxw2Dn8K68LuceIOoBp1ZttqccjiK4Q28x4AY8N9DWgDXecg6iiigAooooAKKKKACiiigAooooAKKKKACkNBNU9Suja2jOg3SH5UX1Y0ARald26xNbtueV14SNcmsa9g1PUbNolsdjFcbpXA9O1b1jZi1jyx3zPzJIerGrdKUVIpScTjLLw/rCzKZZYY0EPk4QEn7xPX8a0m0JorV4YwGR859Sa6Gg9OKOVJC5mzh7C5e1lexu+AG2qT/Ca0jFscjNReJ7RY7qG6GcOfLk/HpTLSZnt2ik/wBbDwW/vD1rzsRCzudtCd0WwcU9TuqFTxUinmuc1IbgVHAR86d8Zqa5+6KqxHN7s9Yz/MUi1sMkHzkVzsQy0X/Xw3866Ob/AFlc/aL5ir7TMf1oLWx0Sj94KuzD9ziqwB3pVq44iHrmhGc9zN0liYYx3DMP1q5qhCtp84HzCcxn/gQqnpvEky8cTMP1q9q6s2jysoGY5Ef6DPNdWGdpnPiFdG2trFcWUUcyB1CjGeowO1QaY7xvc2bsXFu42seuDzV6EgwIwOcoCKpR/Lrlwo/ihVj9cn/CvROI0h0paQcUtABRRRQAUUUUAFFFFABRRRQAUUUUAIelZt7+81OwhPQM0v8A3yP/AK9adZdxxrlmfWNwP0oA0hTqQUtAAahkO0g5qaoLg4hYngAZJ9KaAyPFYDaG7A8hgQay7QZmR84LIA3vV3X5hL4ffByMrg/jVGIYMZ9h/KuHGHXhiwvyOVNTJ1qC4+8DzUsByBzXCjpFn+7VGM41JfeFh+oq9P0HNZpbbqlqcfeLj/x2jqUth9wf3xrC037h/wCurfzrful/eZrn9MHyN/12b+dBpHY6XPzD6CrNyf3I6VX/AOWi/hUt3/q1HrQZvcz7cbL24B6Bw35gGtieIXOnXcGceZC3P6/0rIi4vJx/ejV/6f0rZs2DsuQCGBBHtW1F2kY1leJpadIJtMtZf78Kn8wKghKya5cyA/6uNUP1yT/WmaBITpSxNgNA7RH2AY4/TFVtGuWl1K+DlcSnzUI/u52/zU16qPPN4UtIOlLQAUUUUAFFFFABRRRQAUUUUAFFFFABWNqEgj1/TP8AaEg/SthqwNdby9V0uT+6z8/hQBvDt9KWoFuodgO8Zx2qNrvnCc0AWifU011DoVPQjFQKkrkM3FWOi4FAHDavPJBok0PV45QhHtnP9avhR5CMP7gqh4s2Q3skf8M+1vxFXYznTlb1QGuLF9Drww+blEPtT7bgAVEX328Te1Ptz81cHU63sTXH3RxWVcnZf2TnpvI/NTWrcfczWTeni2YdRcJ/OmKOxbuRmQH2Fc5pxxG3/XZv510snMSn04rmrD7sg9JmH60GkTpGOJVPsKlu/uJUMhxs+gqS4bMaYpEPcpk+Xejj/WQlR+Bz/Wr2my44I+ZWDfrVFlzeWrHuHT8SBj+VLZzNHq0sRONyBx/Krjo0E1eLNO3u006TWw54jfzwfYr/APY1FpI2Xenrn96YGEw9uD/MmsfxPd/Y7xI40LvfIiBB1kIbkflmrmjxXFnqltPOxZrnMUvoOOAPYYr2IO8UeTLRnaClpop1MAooooAKKKKAMT/hL/D3/QZs/wDv6KP+Ev8AD3/QZs/+/or56ooA+hf+Ev8AD3/QZs/+/oo/4S/w9/0GbP8A7+ivnqigD6F/4S/w9/0GbP8A7+ij/hLvD3/QZs/+/or56pRQB9ATeMvD0UbOdYtCFUnAl5Nc8fEmm6jcrc3Gq2KBeYohMPl+vvXjVz/x7v8ASmxf64/QfypoGe722t6FGwMut2H0EorRTxR4bQcavZfXzRXz4fvU802B9Cf8Jd4e/wCgzZ/9/RTZPGHh9UJGsWee370V8+Cmy/6upjuB6n4l1zR763E0Wr2ZljbIHm9RVyHxBoo0tUOrWQYR9PNFeHz/APHvJ+FTf8sj/uVz4lJ7m9F22PZbfxJo5jVDqtoAq9fNHrVmLxDoqyf8hey/7+ivCofuN/uj+Zqdf9Z+FcqpxOpzdj3SfxJoZix/a1n/AN/azLrX9G8lCNVs/llRv9aPWvIpP9X+NVLn/U/8CX+dDpxEpM9zPiLRTFt/tazBz/z1rBs9a0kNPu1O0x5zf8tfevMfT6j+lUoP+W3/AF0P86Xs4lKTPeZPEGinZ/xN7PgdPNFNfxFopiX/AImtn/39FeKt1FRv9xaPZxFzM9ok8QaN5lof7Vs8LPk/vR6VBe6/o0WsWdxHqtoVY+W/73sR3rx2TrB/11H8jUdz96D/AK6L/I01TjdEqT1PdrvWfD9xqGmTvqtk3lO6f6wcbl/+tWlq3iXw+bAtFq9n5kRWQfvBztINeBnraf8AXYf+gtUt7/x5Tf8AXNv5V301ZWOKfxH0Svi/w8VBOsWYJGSPNFL/AMJd4e/6DNn/AN/RXz3/APW/lSGrJPoX/hL/AA9/0GbP/v6KP+Ev8Pf9Bmz/AO/or56ooA+hf+Ev8Pf9Bmz/AO/oo/4S/wAPf9Bmz/7+ivnqigD/2Q==";
				var data = base64image.Base64StringToBitmap();
				var img = new System.Drawing.Bitmap(data);
				
				SessionHelper.ABM_PROFILE_IMAGE = ClipToCircle(img, new PointF(img.Width / 2, img.Height / 2), img.Width / 2, Color.FromArgb(0, 0, 0));
				#endregion

				#region load news
				lblStatus.Text = "Load news";
				string path_update = Path.GetTempPath() + "WFA.OCR";
				if (Directory.Exists(path_update))
				{
					if(Directory.GetFiles(path_update, "i.pikun").Count() > 0)
					{
						string path_info = Directory.GetFiles(path_update, "i.pikun")[0];
						var info = File.ReadAllText(path_info).Split(new string[] { "info:" }, StringSplitOptions.None);
						SessionHelper.SYS_NEWS = info.Last().Replace(";", "\r\n");

						using (News form = new News())
						{
							form.ShowDialog();
						}
					}

					lblStatus.Text = "Clear temp";
					Directory.Delete(path_update, true);
				}
				#endregion

				#region chek version
				lblStatus.Text = "Check version";
				string url_version = @"https://raw.githubusercontent.com/Linlijian/WFA.OCR/master/WFA.OCR/Version/version.txt";

				lblStatus.Text = "Get Main Info";
				FileVersionInfo main_info = GetMainInfo();

				lblStatus.Text = "Get Main Online Version";
				string main_online_version = GetMainOnlineVersion(url_version);

				if (main_info.FileVersion != main_online_version)
				{
					SessionHelper.SYS_ERROR_MESSAGE = "New Version Available\r\nWould you like to download and install the update?";
					SessionHelper.SYS_TITLE = "Update";
				}
				#endregion

				SessionHelper.SYS_START_UP = true;
			}
			catch (Exception e)
			{
				SetError(lblStatus.Text + " " + e.Message, "001", "Error");
				return;
			}
        }
		private void SetError(string _text, string _code, string _title)
		{
			SessionHelper.SYS_START_UP = false;
			SessionHelper.SYS_ERROR_CODE = _code;
			SessionHelper.SYS_ERROR_MESSAGE = "Cann't Load config\r\n" + _text;
			SessionHelper.SYS_TITLE = _title;
		}
		private bool ReadConfig()
		{
			string config = IOHelper.GetFile(SessionHelper.SYS_PATH);
			if (config.IsNullOrEmpty())
			{
				lblStatus.Text = "Not found file ==> Create Folder Config";
				string result = IOHelper.CreateFile(SessionHelper.SYS_CONFIG_PATH);
				if (!result.IsNullOrEmpty())
				{
					SetError(result, "000", "Fail");
					return false;
				}

				config = IOHelper.GetFile(SessionHelper.SYS_PATH);
			}
			
			var arr = IOHelper.ReadConfig(config);

			lblStatus.Text = "Load Hotkey";
			SessionHelper.SYS_HOTKEY = arr.Where(a => a.Contains("Hotkey")).FirstOrDefault().Split(':').Last();

			lblStatus.Text = "Load Source Language";
			SessionHelper.SYS_SOU_LANGUAGE = arr.Where(a => a.Contains("SourceLanguage")).FirstOrDefault().Split(':').Last();

			lblStatus.Text = "Load Target Language";
			SessionHelper.SYS_TAR_LANGUAGE = arr.Where(a => a.Contains("TargetLanguage")).FirstOrDefault().Split(':').Last();

			lblStatus.Text = "Load Google Language";
			SessionHelper.SYS_GOO_LANGUAGE = arr.Where(a => a.Contains("GoogleLanguage")).FirstOrDefault().Split(':').Last();

			//check tessdata in file
			lblStatus.Text = "Create Folder TessData";
			IOHelper.CreateFolder(SessionHelper.SYS_TESSDATA_PATH);

			return true;
		}
		public System.Drawing.Image ClipToCircle(System.Drawing.Image srcImage, PointF center, float radius, Color backGround)
		{
			System.Drawing.Image dstImage = new Bitmap(srcImage.Width, srcImage.Height, srcImage.PixelFormat);
			
			using (Graphics g = Graphics.FromImage(dstImage))
			{
				RectangleF r = new RectangleF(center.X - radius, center.Y - radius,
														 radius * 2, radius * 2);
				
				g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

				using (Brush br = new SolidBrush(backGround))
				{
					g.FillRectangle(br, 0, 0, dstImage.Width, dstImage.Height);
				}

				System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
				path.AddEllipse(r);
				g.SetClip(path);
				g.DrawImage(srcImage, 0, 0);

				return dstImage;
			}
		}
		private FileVersionInfo GetMainInfo()
		{
			var all_file = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "*.exe");
			foreach (var file in all_file)
			{
				FileVersionInfo info = FileVersionInfo.GetVersionInfo(file);
				if (info.ProductName == "WFA.OCR")
				{
					return FileVersionInfo.GetVersionInfo(file);
				}
			}

			return null;
		}
		private string GetMainOnlineVersion(string url_version)
		{
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			using (WebClient webClient = new WebClient())
			{
				using (Stream stream = webClient.OpenRead(url_version))
				{
					StreamReader reader = new StreamReader(stream);
					return (reader.ReadToEnd().Split(new string[] { "#", ":" }, StringSplitOptions.None))[1];
				}
			}
		}
		#endregion

	}
}
