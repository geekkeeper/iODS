using System;

namespace DatabaseUpdate.Entity
{
    /// <summary>
    ///     角色表
    /// </summary>
    public class Role
    {
        /// <summary>
        ///     角色ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        ///     角色名称
        /// </summary>
        public string RoleName { get; set; }

        /// <summary>
        ///     创建人
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        ///     创建时间
        /// </summary>
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        ///     修改人
        /// </summary>
        public string UpdatedBy { get; set; }

        /// <summary>
        ///     修改时间
        /// </summary>
        public DateTime? UpdatedTime { get; set; }

        /// <summary>
        ///     备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 保留字段
        /// </summary>
        public string Reserved { get; set; }
    }
}