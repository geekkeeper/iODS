using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class V_SM_GetPersonResourceForRole : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string subtitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string RoleCode { get; set; }

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
        public string CustomPower { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DataPower { get; set; }

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
        public string SystemResourceDtlCode { get; set; }




    }
}