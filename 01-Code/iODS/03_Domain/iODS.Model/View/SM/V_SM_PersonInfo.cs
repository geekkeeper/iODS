using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class V_SM_PersonInfo : BaseEntity
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
        public string Sex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string SexName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string WorkNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Pwd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DeptCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Duty { get; set; }

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
        public string Superior { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string SuperiorName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DeptName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CorpCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CorpName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string RoleCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string RoleName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DepartCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DepartName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DelFlag { get; set; }




    }
}