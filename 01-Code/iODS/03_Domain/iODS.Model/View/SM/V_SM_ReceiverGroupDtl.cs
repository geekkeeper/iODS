using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class V_SM_ReceiverGroupDtl : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public string GroupCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PersonCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string WorkNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Sex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PersonName { get; set; }

        private int? _Position;
        /// <summary>
        /// 
        /// </summary>
        public int? Position { get => this._Position;
            set => this._Position = value ?? default;
        }

        /// <summary>
        /// 
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DeptName { get; set; }

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