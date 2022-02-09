using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityLib
{
    public class SessionHelper
    {
        /// <summary>
        /// Session control start program
        /// if return true = can start
        /// else return false = cant statrt because something of lose.
        /// </summary>
        public static bool SYS_START_UP;

        /// <summary>
        /// Session rerturn result opendialog.
        /// True = press OK.
        /// False = press Cancel.
        /// </summary>
        public static bool SYS_DIALOG_RESULT;

        public static string SYS_ERROR_MESSAGE;
        public static string SYS_TITLE;
        public static string SYS_ERROR_CODE;

        public static string XML_FOLDER_INPUT;
        public static string XML_FOLDER_OUTPUT;
        public static string XML_CASE_SELECT;
        public static string XML_DUP_FILE;


		public static System.Drawing.Image ABM_PROFILE_IMAGE;
		//public static string TRANS_LANGUAGE_FROM;
		//public static string TRANS_LANGUAGE_TO;
		//public static string TRANS_LANGUAGE;

		public static string SYS_SOU_LANGUAGE;
		public static string SYS_TAR_LANGUAGE;
		public static string SYS_GOO_LANGUAGE;
		public static List<DropDownList> SYS_SOU_LANGUAGES; // google lang code
		public static List<DropDownList> SYS_TAR_LANGUAGES; // train tassdata
		public static string SYS_HOTKEY;
		public static string SYS_TESSDATA;


		public static string SYS_CONFIG_PATH
		{
			get {
				return SYS_PATH + "\\Config.pikun";
			}
		}
		public static string SYS_PATH
		{
			get
			{
				return AppDomain.CurrentDomain.BaseDirectory + "Config";
			}
		}
		public static string SYS_TESSDATA_PATH
		{
			get
			{
				return AppDomain.CurrentDomain.BaseDirectory + "TessData";
			}
		}
		public static string SYS_GOOGLE_LANGUAGES
		{
			get
			{
				// language : google code : train data code
				return "Amharic:am:amh;\r\nArabic:ar:ara;\r\nBengali:bn:ben;\r\nEnglish:en:eng;\r\nPortuguese:pt-BR:por;\r\nBulgarian:bg:bul;\r\nCatalan:ca:cat;\r\nCherokee:chr:chr;\r\nChinese - Simplified:zh-CN:chi_sim;\r\nChinese - Traditional:zh-TW:chi_tra;\r\nDanish:da:dan;\r\nEstonian:et:est;\r\nFinnish:fi:fin;\r\nFrench:fr:fra;\r\nGerman:de:frk;\r\nGreek:el:grc;\r\nGujarati:gu:guj;\r\nHebrew:iw:heb;\r\nHindi:hi:hin;\r\nHungarian:hu:hun;\r\nIcelandic:is:isl;\r\nIndonesian:id:ind;\r\nItalian:it:ita;\r\nJapanese:ja:jpn;\r\nKannada:kn:kan;\r\nKorean:ko:kor;\r\nLatvian:lv:lav;\r\nLithuanian:lt:lit;\r\nMalay:ms:msa;\r\nMalayalam:ml:mal;\r\nMarathi:mr:mar;\r\nNorwegian:no:nor;\r\nPolish:pl:pol;\r\nRomanian:ro:ron;\r\nRussian:ru:rus;\r\nSerbian:sr:srp;\r\nSlovak:sk:slk;\r\nSlovenian:sl:slv;\r\nSpanish:es:spa;\r\nSwahili:sw:swa;\r\nSwedish:sv:swe;\r\nTamil:ta:tam;\r\nTelugu:te:tel;\r\nThai:th:tha;\r\nTurkish:tr:tur;\r\nUrdu:ur:urd;\r\nUkrainian:uk:ukr;\r\nVietnamese:vi:vie;\r\nWelsh:cy:cym;\r\n";
			}
		}
		public static string LANG_DOWNLOAD
		{
			get
			{
				return "amh.traineddata\r\nara.traineddata\r\nben.traineddata\r\neng.traineddata\r\npor.traineddata\r\nbul.traineddata\r\ncat.traineddata\r\nchr.traineddata\r\nchi_sim.traineddata\r\nchi_tra.traineddata\r\ndan.traineddata\r\nest.traineddata\r\nfin.traineddata\r\nfra.traineddata\r\nfrk.traineddata\r\ngrc.traineddata\r\nguj.traineddata\r\nheb.traineddata\r\nhin.traineddata\r\nhun.traineddata\r\nisl.traineddata\r\nind.traineddata\r\nita.traineddata\r\njpn.traineddata\r\nkan.traineddata\r\nkor.traineddata\r\nlav.traineddata\r\nlit.traineddata\r\nmsa.traineddata\r\nmal.traineddata\r\nmar.traineddata\r\nnor.traineddata\r\npol.traineddata\r\nron.traineddata\r\nrus.traineddata\r\nsrp.traineddata\r\nslk.traineddata\r\nslv.traineddata\r\nspa.traineddata\r\nswa.traineddata\r\nswe.traineddata\r\ntam.traineddata\r\ntel.traineddata\r\ntha.traineddata\r\ntur.traineddata\r\nurd.traineddata\r\nukr.traineddata\r\nvie.traineddata\r\ncym.traineddata";
			}
		}

		public static List<DownloadLanguageLink> SYS_LINK_DOWNLOAD_V4;
		public static List<DownloadLanguageLink> SYS_LINK_DOWNLOAD_V41;
		public static List<DownloadLanguageLink> SYS_LINK_DOWNLOAD_V3;
	}
}
