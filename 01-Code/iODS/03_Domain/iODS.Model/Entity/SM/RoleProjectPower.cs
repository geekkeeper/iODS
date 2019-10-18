using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 项目架构树角色数据权限表
    /// </summary>
    [SugarTable("SM_RoleProjectPower")]
    public class RoleProjectPower : BaseEntity
    {
        /// <summary>
        /// 项目架构角色权限项ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public string ID { get; set; }

        /// <summary>
        /// 项目架构关联角色编码
        /// </summary>
        [SugarColumn(ColumnName = "strRoleCode")]
        public string RoleCode { get; set; }

        /// <summary>
        /// 项目架构叶子节点项编码
        /// </summary>
        [SugarColumn(ColumnName = "strProjectCode")]
        public string ProjectCode { get; set; }

        /// <summary>
        /// 项目架构权限项
        /// </summary>
        [SugarColumn(ColumnName = "strItem")]
        public string Item { get; set; }

        /// <summary>
        /// 项目架构权限项父节点编码
        /// </summary>
        [SugarColumn(ColumnName = "strPowerCode")]
        public string PowerCode { get; set; }

        /// <summary>
        /// 数据权限
        /// </summary>
        [SugarColumn(ColumnName = "strDataPower")]
        public string DataPower { get; set; }

        /// <summary>
        /// 自定义权限
        /// </summary>
        [SugarColumn(ColumnName = "strCustomPower")]
        public string CustomPower { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "strIsEnable")]
        public string IsEnable { get; set; }
    }
}