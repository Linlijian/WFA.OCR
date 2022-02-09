
namespace UtilityLib
{
    public class FormState
    {
        public string FolderIntput { get; set; }
        public string FolderOutput { get; set; }
        public string CaseSelect { get; set; }
        public string DupFile { get; set; }
    }

	public class DropDownList
	{
		public string TEXT { get; set; }
		public string VALUE { get; set; }
		public string REMARK { get; set; }
	}

	public class DownloadLanguageLink
	{
		public string LANGUAGE_CODE { get; set; }
		public string LANGUAGE_LINK { get; set; }
		public string LANGUAGE_TEXT { get; set; }
	}
}
