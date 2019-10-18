using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 趋势组和标签点关系表
    /// </summary>
    [SugarTable("PM_TrendGroupAndTag")]
    public class TrendGroupAndTag : BaseEntity
    {
        /// <summary>
        /// 自增ID
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
        /// 趋势组ID
        /// </summary>
        [SugarColumn(ColumnName = "strTrendGroupID")]
        public string TrendGroupId { get; set; }

        /// <summary>
        /// 标签点名称
        /// </summary>
        [SugarColumn(ColumnName = "strTagName")]
        public string TagName { get; set; }

        /// <summary>
        /// 标签点描述
        /// </summary>
        [SugarColumn(ColumnName = "strTagDes")]
        public string TagDes { get; set; }

        /// <summary>
        /// 标签点颜色
        /// </summary>
        [SugarColumn(ColumnName = "strTagColor")]
        public string TagColor { get; set; }

        /// <summary>
        /// 最低值
        /// </summary>
        [SugarColumn(ColumnName = "nLowest")]
        public int Lowest { get; set; }

        /// <summary>
        /// 最高值
        /// </summary>
        [SugarColumn(ColumnName = "nHighest")]
        public int Highest { get; set; }

        /// <summary>
        /// 删除标志，1删除  0未删除
        /// </summary>
        [SugarColumn(ColumnName = "strDelFlag")]
        public string DelFlag { get; set; }
    }
}