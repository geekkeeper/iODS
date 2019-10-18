using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 角色系统资源操作权限表
    /// </summary>
    [SugarTable("SM_RoleSysPower")]
    public class RoleSysPower : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public string ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string RoleCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string SystemResourceDtlCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int PageButtonConfigID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string IsEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "strIsEnable")]
        public string Enable { get; set; }
    }
}