using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class V_SM_Log : BaseEntity
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
        public string strOperater { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime strOperateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string strLabelName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string strLabelDescribe { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int nLogSource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int nStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string strLogSourceName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string strOperateRoute { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string strOperateRouteName { get; set; }

        private int _nOperateContentKey;
        /// <summary>
        /// 
        /// </summary>
        public int nOperateContentKey { get => this._nOperateContentKey;
            set => this._nOperateContentKey = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public string strContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string strOperateContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string strArea { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string strDevice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string strUnit { get; set; }


    }
}