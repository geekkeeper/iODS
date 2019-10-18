using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class V_SM_RoleProjectSysPower : BaseEntity
    {
        private string _ID;
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public string ID { get => this._ID;
            set => this._ID = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public string strRoleCode { get; set; }

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