using System;

namespace iODS.WebApiService.Model
{ 
    /// <summary>
    /// 作者：刘晓凤
    /// 创始时间：2018年10月11日14点37分
    /// 描述：趋势树展示类
    /// </summary>
    public class TrendTreeModel
    {
        /// <summary>
        /// 项目架构树编码或者趋势组id
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
        /// 序号
        /// </summary>
        public int nOrderNo { get; set; }
        /// <summary>
        /// 删除标志，1已删除 0未删除
        /// </summary>
        public string strDelFlag { get; set; }
        /// <summary>
        /// 是否是最终节点，1是  0不是。趋势组是最终节点
        /// </summary>
        public string strIsFinalLeaf { get; set; }
        /// <summary>
        /// 趋势组类别
        /// </summary>
        public int nTrendGroupType { get; set; }
        /// <summary>
        /// 趋势组类别名称 0公共趋势组   1自定义趋势组
        /// </summary>
        public string strTrendGroupTypeName
        {
            get
            {
                return Enum.GetName(typeof(EComLib_TrendGroupTypeEnum), this.nTrendGroupType);
            }
        }
        /// <summary>
        /// GTPlus下装时报表模板ID
        /// </summary>
        public string strID { get; set; }
        /// <summary>
        /// GTPlus下装时工程ID
        /// </summary>
        public string strGTGuid { get; set; }
        /// <summary>
        /// 报表模板资源地址
        /// </summary>
        public string strResourceUrl { get; set; }
        /// <summary>
        /// 是否有权限删除-1 ： 无效， 0：无权限删除，  1：可以删除
        /// </summary>
        public int nDelStatus { get; set; }


    }
    
    /// <summary>
    /// 作者：刘晓凤
    /// 创始时间：2018年10月11日14点43分
    /// 描述：趋势组类型
    /// </summary>
    public enum EComLib_TrendGroupTypeEnum
    {
        请选择    = -1,
        公共趋势组  = 0,
        自定义趋势组 = 1,
    }
}
