namespace iODS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class V_SM_SystemResourceAll : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PCode { get; set; }

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
        public string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string EnTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DelFlag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string IsSysMenu { get; set; }

        private int? _Type;
        /// <summary>
        /// 
        /// </summary>
        public int? Type { get => this._Type;
            set => this._Type = value ?? default;
        }

        /// <summary>
        /// 
        /// </summary>
        public string ResourceUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Parameter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string IsHide { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ExternalNetwork { get; set; }
    }
}