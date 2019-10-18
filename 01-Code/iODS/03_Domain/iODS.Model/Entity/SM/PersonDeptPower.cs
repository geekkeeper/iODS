using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 部门系统资源权限表
    /// </summary>
    [SugarTable("SM_PersonDeptPower")]
    public class PersonDeptPower : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true,ColumnName = "ID")]
        public string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PersonCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DeptCode { get; set; }
    }
}