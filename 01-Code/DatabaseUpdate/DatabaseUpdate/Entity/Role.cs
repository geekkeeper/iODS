namespace DatabaseUpdate.Entity
{
    /// <summary>
    /// 角色表
    /// </summary>
    public class Role
    {
        /// <summary>
        /// 角色ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 角色名称
        /// </summary>
        public string RoleName { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime? CreatedTime { get; set; }

        /// <summary>
        /// 创建人;jAVA后台写入为-1,存储过程批量处理写入为-2,其它情况为真实的用户ID
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public System.DateTime? UpdatedTime { get; set; }

        /// <summary>
        /// 修改人;jAVA后台写入为-1,存储过程批量处理写入为-2,其它情况为真实的用户ID
        /// </summary>
        public string UpdatedBy { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
    }
}