namespace iODS.WebApiService.Model
{
    public class ProjectTagSearchModel: AlarmLogSearchBaseModel
    {
        public string strGTGuid { get; set; }
        public int iCurPage { get; set; }
        public int iPageRowNum { get; set; }
        public string strProjectCode { get; set; }
        public string sWhere { get; set; }
        public string draw { get; set; }
    }
}
