using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 人员-部门关系表
    /// </summary>
    [SugarTable("SM_PersonDepart_Rel")]
    public class PersonDepartment : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true,ColumnName = "ID")]
        public string Id { get; set; }

        /// <summary>
        /// 用户编码
        /// </summary>
        public string PersonCode { get; set; }

        /// <summary>
        /// 归属部门编码
        /// </summary>
        public string DepartCode { get; set; }
    }
}