using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 项目-视频关系表
    /// </summary>
    [SugarTable("M_ProjectVideo")]
    public class ProjectVideo : BaseEntity
    {
        /// <summary>
        /// 视频节点ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public string ID { get; set; }

        /// <summary>
        /// 视频归属工程
        /// </summary>
        [SugarColumn(ColumnName = "strGTGuid")]
        public string GTGuid { get; set; }

        /// <summary>
        /// 视频节点名称
        /// </summary>
        [SugarColumn(ColumnName = "strName")]
        public string Name { get; set; }

        /// <summary>
        /// 视频节点描述
        /// </summary>
        [SugarColumn(ColumnName = "strDescription")]
        public string Description { get; set; }

        /// <summary>
        /// 视频节点父节点编码
        /// </summary>
        [SugarColumn(ColumnName = "strProjectCode")]
        public string ProjectCode { get; set; }

        /// <summary>
        /// 视频节点序号
        /// </summary>
        [SugarColumn(ColumnName = "nOrderNo")]
        public int? OrderNo { get; set; }

        /// <summary>
        /// 视频节点关联视频服务器地址
        /// </summary>
        [SugarColumn(ColumnName = "strResourceUrl")]
        public string ResourceUrl { get; set; }

        /// <summary>
        /// 视频设备类型
        /// </summary>
        [SugarColumn(ColumnName = "strDevType")]
        public string DevType { get; set; }

        /// <summary>
        /// 视频服务器用户名
        /// </summary>
        [SugarColumn(ColumnName = "strUserName")]
        public string UserName { get; set; }

        /// <summary>
        /// 视频服务器访问密码
        /// </summary>
        [SugarColumn(ColumnName = "strPassword")]
        public string Password { get; set; }

        /// <summary>
        /// 删除标志
        /// </summary>
        [SugarColumn(ColumnName = "strDelFlag")]
        public string DelFlag { get; set; }

        /// <summary>
        /// 视频帐户ID
        /// </summary>
        [SugarColumn(ColumnName = "strAccountID")]
        public string AccountID { get; set; }

        /// <summary>
        /// 视频序列号
        /// </summary>
        [SugarColumn(ColumnName = "strSerialNum")]
        public string SerialNum { get; set; }
    }
}