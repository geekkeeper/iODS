using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 项目架构树角色操作权限表
    /// </summary>
    [SugarTable("SM_RoleProjectSysPower")]
    public class RoleProjectSysPower : BaseEntity
    {
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public string ID { get; set; }

        /// <summary>
        /// 角色编码
        /// </summary>
        [SugarColumn(ColumnName = "strRoleCode")]
        public string RoleCode { get; set; }

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
        public int PageButtonConfigID { get; set; }

        /// <summary>
        /// 是否可用
        /// </summary>
        [SugarColumn(ColumnName = "strIsEnable")]
        public string IsEnable { get; set; }
    }
}