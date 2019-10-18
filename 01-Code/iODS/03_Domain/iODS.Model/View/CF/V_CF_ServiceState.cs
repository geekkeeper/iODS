using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class V_CF_ServiceState : BaseEntity
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
        public string strProcessName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string strServiceName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int nState { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string StateName { get; set; }
    }
}