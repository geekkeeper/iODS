namespace iODS.WebApiService.Model
{
    public class AddReportPlanModel
    {
        public string strProjectCode { get; set; }
        public string addList { get; set; }
    }

    public class ReportTemplateInfo
    {
        /// <summary>
        /// 报表模板归属工程标识
        /// </summary>
        public string strGTGuid { get; set; }
        /// <summary>
        /// 报表模板归属工程
        /// </summary>
        public string strGTProject { get; set; }
        /// <summary>
        /// 报表模板标识
        /// </summary>
        public string strID { get; set; }
        /// <summary>
        /// 报表模板名称
        /// </summary>
        public string strName { get; set; }
        /// <summary>
        /// 报表模板描述
        /// </summary>
        public string strDescription { get; set; }
        /// <summary>
        /// 报表服务描述
        /// </summary>
        public string strReportServiceName { get; set; }
        /// <summary>
        /// 报表模板资源地址
        /// </summary>
        public string strResourceUrl { get; set; }
    }

    /// <summary>
    /// 作者：牛文杰
    /// 创始时间：2018年10月11日14点37分
    /// 描述：报表模板项目架构树模型
    /// </summary>
    public class ReportTemplateProjectTreeModel
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
        /// 是否是最终节点，1是  0不是。趋势组是最终节点
        /// </summary>
        public string strIsFinalLeaf { get; set; }
    }
}
