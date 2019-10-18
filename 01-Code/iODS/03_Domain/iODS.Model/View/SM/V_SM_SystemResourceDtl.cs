namespace iODS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class V_SM_SystemResourceDtl : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
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

        /// <summary>
        /// 
        /// </summary>
        public string DeployID { get; set; }
    }
}