namespace DatabaseUpdate.Entity
{
    /// <summary>
    /// 部门用户关系表
    /// </summary>
    public class DepartmentUser
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public int DepartmentId { get; set; }

        /// <summary>
        /// 角色ID
        /// </summary>
        public int UserId { get; set; }
    }
}