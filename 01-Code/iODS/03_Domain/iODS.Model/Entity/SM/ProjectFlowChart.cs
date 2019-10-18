using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 项目架构树和流程图关系表
    /// </summary>
    [SugarTable("SM_ProjectFlowChart")]
    public class ProjectFlowChart : BaseEntity
    {
        /// <summary>
        /// 流程图节点ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true,ColumnName = "ID")]
        public string Id { get; set; }

        /// <summary>
        /// 流程图归属工程ID
        /// </summary>
        [SugarColumn(ColumnName = "strGTGuid")]
        public string GtGuid { get; set; }

        /// <summary>
        /// 流程图归属工程
        /// </summary>
        [SugarColumn(ColumnName = "strGTProject")]
        public string GtProject { get; set; }

        /// <summary>
        /// 流程图组态ID
        /// </summary>
        [SugarColumn(ColumnName = "strID")]
        public string FlowChartId { get; set; }

        /// <summary>
        /// 流程图节点名称
        /// </summary>
        [SugarColumn(ColumnName = "strName")]
        public string Name { get; set; }

        /// <summary>
        /// 流程图节点描述
        /// </summary>
        [SugarColumn(ColumnName = "strDescription")]
        public string Description { get; set; }

        /// <summary>
        /// 流程图父节点编码
        /// </summary>
        [SugarColumn(ColumnName = "strProjectCode")]
        public string ProjectCode { get; set; }

        /// <summary>
        /// 流程图节点序号
        /// </summary>
        [SugarColumn(ColumnName = "nOrderNo")]
        public int? OrderNo { get; set; }

        /// <summary>
        /// 流程图节点关联资源地址
        /// </summary>
        [SugarColumn(ColumnName = "strResourceUrl")]
        public string ResourceUrl { get; set; }

        /// <summary>
        /// 删除标志
        /// </summary>
        [SugarColumn(ColumnName = "strDelFlag")]
        public string DelFlag { get; set; }
    }
}