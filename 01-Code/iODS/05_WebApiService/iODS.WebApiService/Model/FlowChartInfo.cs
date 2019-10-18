namespace iODS.WebApiService.Model
{
    public class FlowChartInfo
    {
        /// <summary>
        /// 流程图归属工程标识
        /// </summary>
        public string strGTGuid { get; set; }
        /// <summary>
        /// 流程图归属工程
        /// </summary>
        public string strGTProject { get; set; }
        /// <summary>
        /// 流程图标识
        /// </summary>
        public string strID { get; set; }
        /// <summary>
        /// 流程图名称
        /// </summary>
        public string strName { get; set; }
        /// <summary>
        /// 流程图描述
        /// </summary>
        public string strDescription { get; set; }
        /// <summary>
        /// 流程图资源地址
        /// </summary>
        public string strResourceUrl { get; set; }
    }
}
