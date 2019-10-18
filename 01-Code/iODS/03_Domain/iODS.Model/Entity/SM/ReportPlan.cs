using System;
using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 报表计划和项目架构树组态表
    /// </summary>
    [SugarTable("SM_ReportPlan")]
    public class ReportPlan : BaseEntity
    {
        /// <summary>
        /// 自增id
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public string ID { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [SugarColumn(ColumnName = "strInputDate")]
        public DateTime InputDate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [SugarColumn(ColumnName = "strModifyDate")]
        public DateTime ModifyDate { get; set; }

        /// <summary>
        /// 工程名称
        /// </summary>
        [SugarColumn(ColumnName = "strGTName")]
        public string GTName { get; set; }

        /// <summary>
        /// GTPlus工程id
        /// </summary>
        [SugarColumn(ColumnName = "strGTGuid")]
        public string GTGuid { get; set; }

        /// <summary>
        /// 报表服务A系统号
        /// </summary>
        [SugarColumn(ColumnName = "strReportServiceA")]
        public string ReportServiceA { get; set; }

        /// <summary>
        /// 报表服务A系统名称
        /// </summary>
        [SugarColumn(ColumnName = "strReportServiceAName")]
        public string ReportServiceAName { get; set; }

        /// <summary>
        /// 报表服务B系统号
        /// </summary>
        [SugarColumn(ColumnName = "strReportServiceB")]
        public string ReportServiceB { get; set; }

        /// <summary>
        /// 报表服务B系统名称
        /// </summary>
        [SugarColumn(ColumnName = "strReportServiceBName")]
        public string ReportServiceBName { get; set; }

        /// <summary>
        /// 报表打印计划名称
        /// </summary>
        [SugarColumn(ColumnName = "strPlanName")]
        public string PlanName { get; set; }

        /// <summary>
        /// 报表服务描述
        /// </summary>
        [SugarColumn(ColumnName = "strPlanDescription")]
        public string PlanDescription { get; set; }

        /// <summary>
        /// 计划属性 1自动  2手动
        /// </summary>
        [SugarColumn(ColumnName = "nPlanAttribute")]
        public int PlanAttribute { get; set; }

        /// <summary>
        /// 是否自动发送打印机 1发送  0不发送
        /// </summary>
        [SugarColumn(ColumnName = "nIsSendPrinter")]
        public int IsSendPrinter { get; set; }

        /// <summary>
        /// 打印周期 1按小时，2按天，3按周，4按月，5按季度，6按年
        /// </summary>
        [SugarColumn(ColumnName = "nPrintCycle")]
        public int PrintCycle { get; set; }

        /// <summary>
        /// 月份，1到12
        /// </summary>
        [SugarColumn(ColumnName = "nMonth")]
        public int? Month { get; set; }

        /// <summary>
        /// 日，1到31
        /// </summary>
        [SugarColumn(ColumnName = "nDay")]
        public int? Day { get; set; }

        /// <summary>
        /// 时，0到23
        /// </summary>
        [SugarColumn(ColumnName = "nHour")]
        public int? Hour { get; set; }

        /// <summary>
        /// 分 0到59
        /// </summary>
        [SugarColumn(ColumnName = "nMinute")]
        public int? Minute { get; set; }

        /// <summary>
        /// 第几个月，为季度报表用
        /// </summary>
        [SugarColumn(ColumnName = "nMonthNumber")]
        public int? MonthNumber { get; set; }

        /// <summary>
        /// 周几，1到7，为周报用
        /// </summary>
        [SugarColumn(ColumnName = "nWeekNumber")]
        public int? WeekNumber { get; set; }

        /// <summary>
        /// 报表模板id
        /// </summary>
        [SugarColumn(ColumnName = "strReportTemplateID")]
        public string ReportTemplateID { get; set; }

        /// <summary>
        /// 报表模板名称
        /// </summary>
        [SugarColumn(ColumnName = "strReportTemplateName")]
        public string ReportTemplateName { get; set; }

        /// <summary>
        /// 报表模板文件磁盘地址
        /// </summary>
        [SugarColumn(ColumnName = "strReportTemplateResourceUrl")]
        public string ReportTemplateResourceUrl { get; set; }

        /// <summary>
        /// 删除标志  1删除  0未删除
        /// </summary>
        [SugarColumn(ColumnName = "strDelFlag")]
        public int DelFlag { get; set; }

        /// <summary>
        /// 重新下装后数据是否同步了，1是同步  0是未同步
        /// </summary>
        [SugarColumn(ColumnName = "strIsSynchronize")]
        public int? IsSynchronize { get; set; }
    }
}