namespace iODS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class V_SM_PersonProjectSysPower : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string strPersonCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string strButtonID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string strButtonName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string strProjectSysPowerCode { get; set; }

        private int? _nPowerCodeType;
        /// <summary>
        /// 
        /// </summary>
        public int? nPowerCodeType { get => this._nPowerCodeType;
            set => this._nPowerCodeType = value ?? default;
        }

        /// <summary>
        /// 
        /// </summary>
        public string strProjectCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string strItemCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int nPageButtonConfigID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string strIsEnable { get; set; }
    }
}