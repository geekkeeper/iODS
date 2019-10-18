using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 趋势组表
    /// </summary>
    [SugarTable("PM_TrendGroup")]
    public class TrendGroup : BaseEntity
    {
        /// <summary>
        /// 趋势组ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true,ColumnName = "ID")]
        public string Id { get; set; }

        /// <summary>
        /// 创建人code
        /// </summary>
        [SugarColumn(ColumnName = "strInputCode")]
        public string InputCode { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [SugarColumn(ColumnName = "strInputDate")]
        public System.DateTime InputDate { get; set; }

        /// <summary>
        /// 部门code
        /// </summary>
        [SugarColumn(ColumnName = "strDeptCode")]
        public string DeptCode { get; set; }

        /// <summary>
        /// 公司code
        /// </summary>
        [SugarColumn(ColumnName = "strCorpCode")]
        public string CorpCode { get; set; }

        /// <summary>
        /// 修改人code
        /// </summary>
        [SugarColumn(ColumnName = "strModifyCode")]
        public string ModifyCode { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [SugarColumn(ColumnName = "strModifyDate")]
        public System.DateTime ModifyDate { get; set; }

        /// <summary>
        /// 趋势组名称
        /// </summary>
        [SugarColumn(ColumnName = "strTrendGroupName")]
        public string TrendGroupName { get; set; }

        /// <summary>
        /// 趋势组类型，0公共趋势组   1自定义趋势组
        /// </summary>
        [SugarColumn(ColumnName = "nTrendGroupType")]
        public int TrendGroupType { get; set; }

        /// <summary>
        /// 项目架构code
        /// </summary>
        [SugarColumn(ColumnName = "strProjectCode")]
        public string ProjectCode { get; set; }

        /// <summary>
        /// 删除标志 1删除  0未删除
        /// </summary>
        [SugarColumn(ColumnName = "strDelFlag")]
        public string DelFlag { get; set; }
    }
}