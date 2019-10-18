namespace iODS.WebApiService.Model
{
    /// <summary>
    /// 作者：刘晓凤
    /// 创始时间：2018年10月11日16点03分
    /// 描述：标签点类
    /// </summary>
    public class TagViewModel
    {
        /// <summary>
        /// 标签点名称
        /// </summary>
        public string strTagName { get; set; }
        /// <summary>
        /// 标签点颜色
        /// </summary>
        public string strTagColor { get; set; }
        /// <summary>
        /// 标签点描述
        /// </summary>
        public string strTagDes { get; set; }
        /// <summary>
        /// 标签点最小值
        /// </summary>
        public decimal nLowest { get; set; }
        /// <summary>
        /// 标签点最大值
        /// </summary>
        public decimal nHighest { get; set; }
        /// <summary>
        /// 序号
        /// </summary>
        public int nOrderNo { get; set; }
        /// <summary>
        /// 标签类型
        /// </summary>
        public int nTagType { get; set; }
        /// <summary>
        /// 报警级
        /// </summary>
        public string AlarmLevel { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// 是否选中  1选中   0未选中
        /// </summary>
        public int IsChecked { get; set; }
        /// <summary>
        /// 标签点id
        /// </summary>
        public string strID { get; set; }
    }
}
