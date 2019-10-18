using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class V_CF_Alarm : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public string strProjectCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string strProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public string ID { get; set; }

        private int? _nAlarmType;
        /// <summary>
        /// 
        /// </summary>
        public int? nAlarmType { get => this._nAlarmType;
            set => this._nAlarmType = value ?? default;
        }

        private int? _nAlarmState;
        /// <summary>
        /// 
        /// </summary>
        public int? nAlarmState { get => this._nAlarmState;
            set => this._nAlarmState = value ?? default;
        }

        private int? _nAlarmlevel;
        /// <summary>
        /// 
        /// </summary>
        public int? nAlarmlevel { get => this._nAlarmlevel;
            set => this._nAlarmlevel = value ?? default;
        }

        private System.DateTime? _strEventTime;
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? strEventTime { get => this._strEventTime;
            set => this._strEventTime = value ?? default;
        }

        /// <summary>
        /// 
        /// </summary>
        public string strTagName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string strTagDes { get; set; }

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

        /// <summary>
        /// 
        /// </summary>
        public string strMsgDes { get; set; }

        private double? _fAlarmlimit;
        /// <summary>
        /// 
        /// </summary>
        public double? fAlarmlimit { get => this._fAlarmlimit;
            set => this._fAlarmlimit = value ?? default;
        }

        /// <summary>
        /// 
        /// </summary>
        public string strAlarmValue { get; set; }

        private System.DateTime? _strRecoveryTime;
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? strRecoveryTime { get => this._strRecoveryTime;
            set => this._strRecoveryTime = value ?? default;
        }

        private System.DateTime? _strAckedTime;
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? strAckedTime { get => this._strAckedTime;
            set => this._strAckedTime = value ?? default;
        }

        /// <summary>
        /// 
        /// </summary>
        public string strAckedComment { get; set; }

        private int? _nSource;
        /// <summary>
        /// 
        /// </summary>
        public int? nSource { get => this._nSource;
            set => this._nSource = value ?? default;
        }

        /// <summary>
        /// 
        /// </summary>
        public string strIsHide { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string strNodeDomain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string strTypeName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string strAlarmTypeDes { get; set; }

        private int? _nPushStatus;
        /// <summary>
        /// 
        /// </summary>
        public int? nPushStatus { get => this._nPushStatus;
            set => this._nPushStatus = value ?? default;
        }

        /// <summary>
        /// 
        /// </summary>
        public string strAlarmLevelDes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public string strName { get; set; }
    }
}