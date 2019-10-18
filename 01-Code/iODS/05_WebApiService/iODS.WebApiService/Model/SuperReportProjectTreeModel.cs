namespace iODS.WebApiService.Model
{
    /// <summary>
    /// 作者：牛文杰
    /// 创始时间：2018年10月11日14点37分
    /// 描述：设置报表项目架构树模型
    /// </summary>
    public class SuperReportProjectTreeModel
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
        /// 名称
        /// </summary>
        public string strName { get; set; }
        /// <summary>
        /// 高级报表标识
        /// </summary>
        public string strID { get; set; }
        /// <summary>
        /// 序号
        /// </summary>
        public int nOrderNo { get; set; }
        /// <summary>
        /// 资源地址
        /// </summary>
        public string strResourceUrl { get; set; }
        /// <summary>
        /// 厂商ID
        /// </summary>
        public string strCompanyID { get; set; }
        /// <summary>
        /// 访问用户名
        /// </summary>
        public string strUserName { get; set; }
        /// <summary>
        /// 用户密码
        /// </summary>
        public string strPassword { get; set; }
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
