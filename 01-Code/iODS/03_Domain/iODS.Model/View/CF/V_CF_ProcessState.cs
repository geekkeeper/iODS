using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class V_CF_ProcessState : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public string ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int nNodePCID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int nProcessID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string strProcessName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int nState { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string StateName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime strStateTime { get; set; }

        private int? _IsHaveDetail;
        /// <summary>
        /// 
        /// </summary>
        public int? IsHaveDetail { get => this._IsHaveDetail;
            set => this._IsHaveDetail = value ?? default;
        }
    }
}