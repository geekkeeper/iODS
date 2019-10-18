using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 系统按钮配置表:系统资源操作按钮字典
    /// </summary>
    [SugarTable("SM_PageButtonConfig")]
    public class PageButtonConfig : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true,ColumnName = "ID")]
        public string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string SystemResourceDtlCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ResourceUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "ButtonID")]
        public string ButtonId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ButtonName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string IsSysMenu { get; set; }
    }
}