using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class V_SM_ProjectVideo : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public string ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string strGTGuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string strName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string strDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string strProjectCode { get; set; }

        private int? _nOrderNo;
        /// <summary>
        /// 
        /// </summary>
        public int? nOrderNo { get => this._nOrderNo;
            set => this._nOrderNo = value ?? default;
        }

        /// <summary>
        /// 
        /// </summary>
        public string strResourceUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string strDevType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string strUserName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string strPassword { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string strDelFlag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string strAccountID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string strSerialNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string strAccountName { get; set; }
    }
}