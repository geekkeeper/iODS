using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 项目架构管理树
    /// </summary>
    [SugarTable("SM_ProjectArchitecture")]
    public class ProjectArchitecture : BaseEntity
    {
        /// <summary>
        /// 项目节点ID
        /// </summary>
        [SugarColumn(ColumnName = "ID")]
        public string Id { get; set; }

        /// <summary>
        /// 项目节点编码
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public string ProjectCode { get; set; }

        /// <summary>
        /// 项目父项节点编码
        /// </summary>
        [SugarColumn(ColumnName = "strPProjectCode")]
        public string PProjectCode { get; set; }

        /// <summary>
        /// 项目节点名称
        /// </summary>
        [SugarColumn(ColumnName = "strName")]
        public string Name { get; set; }

        /// <summary>
        /// 项目节点序号
        /// </summary>
        [SugarColumn(ColumnName = "nOrderNo")]
        public int? OrderNo { get; set; }

        /// <summary>
        /// 是否为最终叶子节点
        /// </summary>
        [SugarColumn(ColumnName = "strIsFinalLeaf")]
        public string IsFinalLeaf { get; set; }

        /// <summary>
        /// 删除标志
        /// </summary>
        [SugarColumn(ColumnName = "strDelFlag")]
        public string DelFlag { get; set; }
    }
}