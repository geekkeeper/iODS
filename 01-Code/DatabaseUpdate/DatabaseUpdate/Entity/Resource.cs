using System;

namespace DatabaseUpdate.Entity
{
    /// <summary>
    /// 系统资源表
    /// </summary>
    public class Resource
    {
        /// <summary>
        /// 资源编号
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 资源名称
        /// </summary>
        public string ResourceName { get; set; }

        /// <summary>
        /// 资源连接地址
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 资源图标
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// 资源类型；0:菜单;1：按钮
        /// </summary>
        public string ResourceType { get; set; }

        /// <summary>
        /// 资源值
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// 资源状态；Y:启用;N：禁用
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 父资源编号
        /// </summary>
        public string ParentId { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        public string UpdatedBy { get; set; }

        /// <summary>
        /// 修改时间
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