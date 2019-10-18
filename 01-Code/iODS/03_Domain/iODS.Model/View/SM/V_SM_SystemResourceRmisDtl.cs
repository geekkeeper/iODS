using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class V_SM_SystemResourceRmisDtl : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DelFlag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public string ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string IsHide { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string IsSysMenu { get; set; }

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
        public string Parameter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ResourceType { get; set; }

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
        public string Platform { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ConfCodeVou { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ResourceUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public string DeployID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ResourceUrlApp { get; set; }
    }
}