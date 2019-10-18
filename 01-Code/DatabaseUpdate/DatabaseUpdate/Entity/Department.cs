using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using DatabaseUpdate.Annotation.Common;
using DatabaseUpdate.Annotation.Field;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DatabaseUpdate.Entity
{
    /// <summary>
    /// 部门
    /// </summary>
    [UsedName("department")]
    [UsingName(nameof(Department))]
    public class Department
    {
        /// <summary>
        /// 部门ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        [DataType("varchar(50)")]
        [UsedName("DeptName")]
        [UsingName(nameof(Name))]
        public string Name { get; set; }

        /// <summary>
        /// 上级部门ID
        /// </summary>
        ///
        [DataType("")]
        [MaxLength(20)]
        [UsedName("ParentDeptId")]
        [UsingName(nameof(Name))]
        public string SuperiorId { get; set; }

        /// <summary>
        /// 领导
        /// </summary>
        public string Leader { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// 创建人;
        /// </summary>
        [StringLength(50)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [DefaultValue(10)]
        public DateTime? UpdatedTime { get; set; }

        /// <summary>
        /// 修改人;
        /// </summary>
        [DeleteField("v1.0.0.0")]
        public string UpdatedBy { get; set; }

        /// <summary>
        /// 类型布尔值，true代表为分公司，false表示不是分公司
        /// </summary>
        public string Branch { get; set; }
    }
}