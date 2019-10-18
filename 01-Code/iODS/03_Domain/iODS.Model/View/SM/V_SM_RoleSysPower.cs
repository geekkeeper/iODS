using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class V_SM_RoleSysPower : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public string RoleCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string IsEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ButtonID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ButtonName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string SystemResourceDtlCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string IsSysMenu { get; set; }

        private string _ID;
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public string ID { get => this._ID;
            set => this._ID = value;
        }


    }
}