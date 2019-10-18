using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 项目-标签关系表
    /// </summary>
    [SugarTable("")]
    public class ProjectTag : BaseEntity
    {
        /// <summary>
        /// 标签节点ID
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// 标签组态ID
        /// </summary>
        [SugarColumn(ColumnName = "strID")]
        public string TagID { get; set; }

        /// <summary>
        /// 标签节点名称
        /// </summary>
        [SugarColumn(IsPrimaryKey = true,ColumnName = "strName")]
        public string TagName { get; set; }

        /// <summary>
        /// 标签节点描述
        /// </summary>
        [SugarColumn(ColumnName = "strDescription")]
        public string TagDescription { get; set; }

        /// <summary>
        /// 区域，为DCS日志设计
        /// </summary>
        [SugarColumn(ColumnName = "strArea")]
        public string TagArea { get; set; }

        /// <summary>
        /// 装置，为DCS日志设计
        /// </summary>
        [SugarColumn(ColumnName = "strDevice")]
        public string TagDevice { get; set; }

        /// <summary>
        /// 单元,为DCS日志设计
        /// </summary>
        [SugarColumn(ColumnName = "strUnit")]
        public string TagUnit { get; set; }

        /// <summary>
        /// 标签节点父节点编码
        /// </summary>
        [SugarColumn(ColumnName = "strProjectCode")]
        public string ProjectCode { get; set; }

        /// <summary>
        /// 标签节点序号
        /// </summary>
        [SugarColumn(ColumnName = "nOrderNo")]
        public int? OrderNo { get; set; }

        /// <summary>
        /// 标签节点类型（0：普通标签，1：特殊标签）
        /// </summary>
        [SugarColumn(ColumnName = "nTagType")]
        public int? TagType { get; set; }

        /// <summary>
        /// 标签节点资源地址
        /// </summary>
        [SugarColumn(ColumnName = "strResourceUrl")]
        public string ResourceUrl { get; set; }

        /// <summary>
        /// 标签归属工程标识
        /// </summary>
        [SugarColumn(ColumnName = "strGTGuid")]
        public string TagGTGuid { get; set; }

        /// <summary>
        /// 标签归属PC
        /// </summary>
        [SugarColumn(ColumnName = "strGTPC")]
        public string GTNode { get; set; }

        /// <summary>
        /// 标签归属MACS域号
        /// </summary>
        [SugarColumn(ColumnName = "strGTDomain")]
        public string TagGTDomain { get; set; }

        /// <summary>
        /// 删除标志
        /// </summary>
        [SugarColumn(ColumnName = "strDelFlag")]
        public string DelFlag { get; set; }

        /// <summary>
        /// 标签数据类型：开关，模拟
        /// </summary>
        [SugarColumn(ColumnName = "nTagDataType")]
        public int? TagDataType { get; set; }
    }
}