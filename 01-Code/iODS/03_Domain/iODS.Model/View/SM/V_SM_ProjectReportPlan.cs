using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class V_SM_ProjectReportPlan : BaseEntity
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
        public string strID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string strGTGuid { get; set; }

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
        public string strPlanName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string strPlanDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string strReportTemplateResourceUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string strGTName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string strReportServiceAName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string strReportServiceBName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string strDelFlag { get; set; }


    }
}