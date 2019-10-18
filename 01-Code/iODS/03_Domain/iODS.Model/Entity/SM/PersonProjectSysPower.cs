using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 项目架构树按扭操作表
    /// </summary>
    [SugarTable("SM_PersonProjectSysPower")]
    public class PersonProjectSysPower : BaseEntity
    {
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true,ColumnName = "ID")]
        public string Id { get; set; }

        /// <summary>
        /// 用户编码
        /// </summary>
        [SugarColumn(ColumnName = "strPersonCode")]
        public string PersonCode { get; set; }

        /// <summary>
        /// 授权项编码
        /// </summary>
        [SugarColumn(ColumnName = "strItemCode")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 项目结构节点编码
        /// </summary>
        [SugarColumn(ColumnName = "strProjectCode")]
        public string ProjectCode { get; set; }

        /// <summary>
        /// 操作按钮ID
        /// </summary>
        [SugarColumn(ColumnName = "nPageButtonConfigID")]
        public int PageButtonConfigId { get; set; }

        /// <summary>
        /// 是否可用
        /// </summary>
        [SugarColumn(ColumnName = "strIsEnable")]
        public string IsEnable { get; set; }
    }
}