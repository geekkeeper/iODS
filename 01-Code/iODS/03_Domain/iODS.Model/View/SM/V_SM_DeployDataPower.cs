using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class V_SM_DeployDataPower : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public string Parameter { get; set; }

        private int? _DeployID;
        /// <summary>
        /// 
        /// </summary>
        public int? DeployID { get => this._DeployID;
            set => this._DeployID = value ?? default;
        }

        /// <summary>
        /// 
        /// </summary>
        public string path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int pid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PersonCode { get; set; }

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
        [SugarColumn(IsPrimaryKey = true)]
        public string Id { get; set; }
    }
}