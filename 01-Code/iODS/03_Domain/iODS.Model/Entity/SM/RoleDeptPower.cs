using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 角色系统资源部门权限表
    /// </summary>
    [SugarTable("SM_RoleDeptPower")]
    public class RoleDeptPower : BaseEntity
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
        public string DeptCode { get; set; }
    }
}