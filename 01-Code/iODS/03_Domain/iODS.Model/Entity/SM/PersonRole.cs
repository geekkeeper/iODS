using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 人员-角色关系表
    /// </summary>
    [SugarTable("SM_PersonRole_Rel")]
    public class PersonRole : BaseEntity
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
        public string RoleCode { get; set; }
    }
}