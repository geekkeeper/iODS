using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 系统页面资源一级表:系统资源决定首页的显示菜单（生产监视，系统管理，系统设置）
    /// </summary>
    [SugarTable("SM_SystemResource")]
    public class SystemResource : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public string ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string EnTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? OrderNo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string IsHide { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string IsSysMenu { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Platform { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DelFlag { get; set; }
    }
}