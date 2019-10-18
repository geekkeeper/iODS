using System;

namespace iODS.WebApiService.Model
{
    public class SM_ReportRecordViewModel
    {
        public string ID { get; set; }
        public string PID { get; set; }
        public DateTime strInputDate { get; set; }
        public DateTime strModifyDate { get; set; }
        public string strReportNameAndTime { get; set; }
        public string strOperatorAccount { get; set; }
        public int strDelFlag { get; set; }
    }
}
