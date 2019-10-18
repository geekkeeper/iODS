using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 项目-高级报表关系表
    /// </summary>
    [SugarTable("")]
    public class ProjectSuperReport : BaseEntity
    {
        /// <summary>
        /// 高级报表节点ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public string ID { get; set; }

        /// <summary>
        /// 高级报表归属工程
        /// </summary>
        [SugarColumn(ColumnName = "strGTGuid")]
        public string SuperReportGTGuid { get; set; }

        /// <summary>
        /// 高级报表节点名称
        /// </summary>
        [SugarColumn(ColumnName = "strName")]
        public string SuperReportName { get; set; }

        /// <summary>
        /// 高级报表节点描述
        /// </summary>
        [SugarColumn(ColumnName = "strDescription")]
        public string SuperReportDescription { get; set; }

        /// <summary>
        /// 高级报表节点父节点编码
        /// </summary>
        [SugarColumn(ColumnName = "strProjectCode")]
        public string ProjectCode { get; set; }

        /// <summary>
        /// 高级报表节点序号
        /// </summary>
        [SugarColumn(ColumnName = "nOrderNo")]
        public int? OrderNo { get; set; }

        /// <summary>
        /// 高级报表节点关联服务器地址
        /// </summary>
        [SugarColumn(ColumnName = "strResourceUrl")]
        public string ResourceUrl { get; set; }

        /// <summary>
        /// 高级报表厂商ID
        /// </summary>
        [SugarColumn(ColumnName = "strCompanyID")]
        public string CompanyID { get; set; }

        /// <summary>
        /// 高级报表服务器用户名
        /// </summary>
        [SugarColumn(ColumnName = "strUserName")]
        public string UserName { get; set; }

        /// <summary>
        /// 高级报表服务器访问密码
        /// </summary>
        [SugarColumn(ColumnName = "strPassword")]
        public string Password { get; set; }

        /// <summary>
        /// 删除标志
        /// </summary>
        [SugarColumn(ColumnName = "strDelFlag")]
        public string DelFlag { get; set; }
    }
}