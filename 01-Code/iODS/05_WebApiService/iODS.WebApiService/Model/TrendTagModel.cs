using System.Collections.Generic;

namespace iODS.WebApiService.Model
{
    /// <summary>
    /// 作者：刘晓凤
    /// 创始时间：2018年10月8日16点05分
    /// 描述：趋势图标签类
    /// </summary>
    public class TrendTagModel
    {
        /// <summary>
        /// 标签点名称
        /// </summary>
        public string strTagName { get; set; }
        /// <summary>
        /// 标签点值
        /// </summary>
        public string nTagValue { get; set; }
        /// <summary>
        /// 标签点时间
        /// </summary>
        public string strTagTime { get; set; }
        /// <summary>
        /// 上限
        /// </summary>
        public string nHighest { get; set; }
        /// <summary>
        /// 下限
        /// </summary>
        public string nLowest { get; set; }
        /// <summary>
        /// 质量位  1是正常， 非1是其他
        /// </summary>
        public string ulMassStatues { get; set; }
        /// <summary>
        /// 标签点值集合
        /// </summary>
        public List<TrendTagModel> tagValueList { get; set; }

        /// <summary>
        /// 标签类型，0是布尔 7是模拟
        /// </summary>
        public string ulSType { get; set; }

        /// <summary>
        /// 标签点id
        /// </summary>
        public string strID { get; set; }
        /// <summary>
        /// 标签点状态码 0:成功 1:点名不存在 2:参数错误 3:预留 4:超时
        /// </summary>
        public int lErrorNo { get; set; }
    }
}
