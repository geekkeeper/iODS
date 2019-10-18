using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class V_SM_MessageInfoAll : BaseEntity
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
        public string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PersonCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string IsRead { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DelFlag { get; set; }

        private System.DateTime? _SendTime;
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? SendTime { get => this._SendTime;
            set => this._SendTime = value ?? default;
        }

        /// <summary>
        /// 
        /// </summary>
        public string Sender { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string SenderName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public string PID { get; set; }

        private int? _MsgType;
        /// <summary>
        /// 
        /// </summary>
        public int? MsgType { get => this._MsgType;
            set => this._MsgType = value ?? default;
        }

        private int? _nPushStatus;
        /// <summary>
        /// 
        /// </summary>
        public int? nPushStatus { get => this._nPushStatus;
            set => this._nPushStatus = value ?? default;
        }

        private int? _Client;
        /// <summary>
        /// 
        /// </summary>
        public int? Client { get => this._Client;
            set => this._Client = value ?? default;
        }


    }
}