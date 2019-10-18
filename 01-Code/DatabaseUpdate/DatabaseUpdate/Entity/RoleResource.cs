namespace DatabaseUpdate.Entity
{
    /// <summary>
    /// 角色资源
    /// </summary>
    public class RoleResource
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 资源编号
        /// </summary>
        public string ResourceId { get; set; }

        /// <summary>
        /// 角色编号
        /// </summary>
        public int? RoleId { get; set; }
    }
}