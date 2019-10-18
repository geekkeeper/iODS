namespace iODS.WebApiService.Model
{
    public class AlramSearchModel : AlarmLogSearchBaseModel
    {
        public string strProjectCode { get; set; }
        public int iCurPage { get; set; }
        public int iPageRowNum { get; set; }
        public string sWhere { get; set; }
        public string sOrder { get; set; }
        public string draw { get; set; }
        public string personCode { get; set; }
    }
}
