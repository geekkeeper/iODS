using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class V_SM_MessageInfo : BaseEntity
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
        public string Sender { get; set; }

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
        public string Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DelFlag { get; set; }

        private System.DateTime? _EndTime;
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? EndTime { get => this._EndTime;
            set => this._EndTime = value ?? default;
        }

        /// <summary>
        /// 
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string InputCode { get; set; }

        private System.DateTime? _InputDate;
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? InputDate { get => this._InputDate;
            set => this._InputDate = value ?? default;
        }

        /// <summary>
        /// 
        /// </summary>
        public string DeptCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CorpCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ModifyCode { get; set; }

        private System.DateTime? _ModifyDate;
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? ModifyDate { get => this._ModifyDate;
            set => this._ModifyDate = value ?? default;
        }

        private int? _MsgType;
        /// <summary>
        /// 
        /// </summary>
        public int? MsgType { get => this._MsgType;
            set => this._MsgType = value ?? default;
        }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        private int? _nPushStatus;
        /// <summary>
        /// 
        /// </summary>
        public int? nPushStatus { get => this._nPushStatus;
            set => this._nPushStatus = value ?? default;
        }


    }
}