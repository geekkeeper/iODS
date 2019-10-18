using System;

namespace iODS.WebApiService.Model
{
    public class SM_ReportPlanViewModel
    {
        public string ID { get; set; }
        public DateTime strInputDate { get; set; }
        public DateTime strModifyDate { get; set; }
        public string strGTName { get; set; }
        public string strGTGuid { get; set; }
        public string strReportServiceA { get; set; }
        public string strReportServiceAName { get; set; }
        public string strReportServiceB { get; set; }
        public string strReportServiceBName { get; set; }
        public string strPlanName { get; set; }
        public string strPlanDescription { get; set; }
        public int nPlanAttribute { get; set; }
        public int nIsSendPrinter { get; set; }
        public int nPrintCycle { get; set; }
        public int nMonth { get; set; }
        public int nDay { get; set; }
        public int nHour { get; set; }
        public int nMinute { get; set; }
        public int nMonthNumber { get; set; }
        public int nWeekNumber { get; set; }
        public string strReportTemplateID { get; set; }
        public string strReportTemplateName { get; set; }
        public string strReportTemplateResourceUrl { get; set; }
        public int strDelFlag { get; set; }

        /// <summary>
        /// 是否自动发送打印机 1发送  0不发送
        /// </summary>
        public string IsSendPrinterName
        {
            get { return Enum.GetName(typeof(EComLib_IsSendPrinterEnum), this.nIsSendPrinter); }
        }
        /// <summary>
        /// 打印周期 1按小时，2按天，3按周，3按月，4按季度，5按年
        /// </summary>
        public string PrintCycleName
        {
            get { return Enum.GetName(typeof(EComLib_PrintCycleNameEnum), this.nPrintCycle); }
        }
        /// <summary>
        /// 计划属性 1自动  2手动
        /// </summary>
        public string PlanAttributeName
        {
            get { return Enum.GetName(typeof(EComLib_PlanAttributeEnum), this.nPlanAttribute); }
        }
        /// <summary>
        /// 报表名称(带生成时间)
        /// </summary>
        public string strReportNameAndTime { get; set; }
        /// <summary>
        /// 执行人（自动报表为空）
        /// </summary>
        public string strOperatorAccount { get; set; }
        /// <summary>
        /// 记录的id
        /// </summary>
        public string RecordID { get; set; }
        /// <summary>
        /// 计划id
        /// </summary>
        public string PlanID { get; set; }
        /// <summary>
        /// 重新下装后数据是否同步了，1是同步  0是未同步
        /// </summary>
        public int strIsSynchronize { get; set; }
        public string ProjectName { get; set; }
    }
    /// <summary>
    /// 是否自动发送打印机 1发送  0不发送
    /// </summary>
    public enum EComLib_IsSendPrinterEnum
    {
        发送  = 1,
        不发送 = 0,
    }
    /// <summary>
    /// 打印周期 1按小时，2按天，3按周，4按月，5按季度，6按年
    /// </summary>
    public enum EComLib_PrintCycleNameEnum
    {
        按小时 = 1,
        按天  = 2,
        按周  = 3,
        按月  = 4,
        按季度 = 5,
        按年  = 6,
    }
    /// <summary>
    /// 计划属性 1自动  2手动
    /// </summary>
    public enum EComLib_PlanAttributeEnum
    {
        自动 = 1,
        手动 = 2,
    }
}
