using System;

namespace DatabaseUpdate.Entity
{
    /// <summary>
    /// 部门
    /// </summary>
    public class Department
    {
        /// <summary>
        /// 部门ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        public string DepartmentName { get; set; }

        /// <summary>
        /// 类型布尔值，true代表为分公司，false表示不是分公司
        /// </summary>
        public bool Branch { get; set; }
        
        /// <summary>
        /// 上级部门ID
        /// </summary>
        public int SuperiorId { get; set; }

        /// <summary>
        /// 领导
        /// </summary>
        public int Leader { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// 创建人;
        /// </summary>
        public int CreatedBy { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime? UpdatedTime { get; set; }

        /// <summary>
        /// 修改人;
        /// </summary>
        public int UpdatedBy { get; set; }

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