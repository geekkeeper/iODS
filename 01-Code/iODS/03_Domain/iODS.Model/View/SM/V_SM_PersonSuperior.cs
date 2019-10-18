using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class V_SM_PersonSuperior : BaseEntity
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
        public string Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CorpCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DelFlag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DeptCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Duty { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PersonStatus { get; set; }

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
        public string Sex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string WorkNum { get; set; }

        private int? _OrderNo;
        /// <summary>
        /// 
        /// </summary>
        public int? OrderNo { get => this._OrderNo;
            set => this._OrderNo = value ?? default;
        }

        /// <summary>
        /// 
        /// </summary>
        public string Superior { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string SuperiorName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string RoleCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string RoleName { get; set; }






    }
}