using System;

namespace DatabaseUpdate.Entity
{
    /// <summary>
    /// 工程
    /// </summary>
    public class Project
    {
        /// <summary>
        ///     工程ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        ///     工程名称
        /// </summary>
        public string ProjectName { get; set; }

        /// <summary>
        /// GTPlus 组态工程编号
        /// </summary>
        public string GTProjectCode { get; set; }

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