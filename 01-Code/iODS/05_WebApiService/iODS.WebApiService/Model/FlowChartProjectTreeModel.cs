namespace iODS.WebApiService.Model
{
    /// <summary>
    /// 作者：牛文杰
    /// 创始时间：2018年10月11日14点37分
    /// 描述：流程图项目架构树
    /// </summary>
    public class FlowChartProjectTreeModel
    {
        /// <summary>
        /// 项目架构树编码或者流程图Code
        /// </summary>
        public string strProjectCode { get; set; }
        /// <summary>
        /// 父级节点code
        /// </summary>
        public string strPProjectCode { get; set; }
        /// <summary>
        /// GT工程GUID
        /// </summary>
        public string strGTGuid { get; set; }
        /// <summary>
        /// GT工程GUID
        /// </summary>
        public string strGTProject { get; set; }
        /// <summary>
        /// 流程图GTID
        /// </summary>
        public string strID { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string strName { get; set; }
        /// <summary>
        /// 序号
        /// </summary>
        public int nOrderNo { get; set; }
        /// <summary>
        /// 资源地址
        /// </summary>
        public string strResourceUrl { get; set; }
        /// <summary>
        /// 删除标志，1已删除 0未删除
        /// </summary>
        public string strDelFlag { get; set; }
        /// <summary>
        /// 是否是最终节点，1是  0不是
        /// </summary>
        public string strIsFinalLeaf { get; set; }
    }
}
