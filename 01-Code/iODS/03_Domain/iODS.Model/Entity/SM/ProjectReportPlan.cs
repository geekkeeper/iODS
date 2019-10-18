using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 项目-报表计划关系表
    /// </summary>
    [SugarTable("SM_ProjectReportPlan")]
    public class ProjectReportPlan : BaseEntity
    {
        /// <summary>
        /// 报表计划ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public string ID { get; set; }

        /// <summary>
        /// 报表计划组态ID
        /// </summary>
        [SugarColumn(ColumnName = "")]
        public string GTReportPlanID { get; set; }

        /// <summary>
        /// 报表计划名称
        /// </summary>
        [SugarColumn(ColumnName = "strName")]
        public string ReportPlanName { get; set; }

        /// <summary>
        /// 报表计划描述
        /// </summary>
        [SugarColumn(ColumnName = "strDescription")]
        public string ReportPlanDescription { get; set; }

        /// <summary>
        /// 报表计划父节点编码
        /// </summary>
        [SugarColumn(ColumnName = "strProjectCode")]
        public string ProjectCode { get; set; }

        /// <summary>
        /// 报表计划序号
        /// </summary>
        [SugarColumn(ColumnName = "nOrderNo")]
        public int? OrderNo { get; set; }

        /// <summary>
        /// 报表计划关联资源地址
        /// </summary>
        [SugarColumn(ColumnName = "strResourceUrl")]
        public string ResourceUrl { get; set; }

        /// <summary>
        /// 报表服务名称
        /// </summary>
        [SugarColumn(ColumnName = "strReportServiceName")]
        public string ReportServiceName { get; set; }

        /// <summary>
        /// 报表计划归属工程
        /// </summary>
        [SugarColumn(ColumnName = "strGTGuid")]
        public string GTGuid { get; set; }

        /// <summary>
        /// 报表计划归属工程标识
        /// </summary>
        [SugarColumn(ColumnName = "strGTProject")]
        public string GTProject { get; set; }

        /// <summary>
        /// 删除标志
        /// </summary>
        [SugarColumn(ColumnName = "strDelFlag")]
        public string DelFlag { get; set; }
    }
}