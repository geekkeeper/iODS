using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 系统页面资源子表:系统资源子菜单
    /// </summary>
    [SugarTable("")]
    public class SystemResourceDtl : BaseEntity
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
        public string SystemResourceCode { get; set; }

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
        public string ResourceType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ResourceUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ResourceUrlApp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Parameter { get; set; }

        private int? _OrderNo;
        /// <summary>
        /// 
        /// </summary>
        public int? OrderNo { get => this._OrderNo;
            set => this._OrderNo = value ?? default;
        }

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
        public string ConfCodeVou { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DelFlag { get; set; }
    }
}