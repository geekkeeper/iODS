using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class V_SM_PersonResourceForCode : BaseEntity
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
        public string PersonCode { get; set; }

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
        public string DataPower { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CustomPower { get; set; }

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