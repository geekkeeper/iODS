using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 公司/部门表
    /// </summary>
    [SugarTable("SM_Department",)]
    public class Department : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true,ColumnName = "ID")]
        public string Id { get; set; }

        /// <summary>
        /// 部门/公司编号
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 上级部门
        /// </summary>
        [SugarColumn(ColumnName = "Pcode")]
        public string ParentCode { get; set; }

        /// <summary>
        /// 部门/公司名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Charge { get; set; }

        /// <summary>
        /// 排序号
        /// </summary>
        public int? OrderNo { get; set; }

        /// <summary>
        /// 是否是公司
        /// </summary>
        public string IsCompany { get; set; }

        /// <summary>
        /// 是否是生产部门
        /// </summary>
        public string IsProductionDept { get; set; }

        /// <summary>
        /// 删除标识
        /// </summary>
        public string DelFlag { get; set; }
    }
}