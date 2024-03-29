using DatabaseUpdate.Annotation.Table;

namespace DatabaseUpdate.Entity
{
    /// <summary>
    /// 用户角色
    /// </summary>
    [EnabledTable(false)]
    public class UserRole
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// 角色ID
        /// </summary>
        public int RoleId { get; set; }
    }
}