namespace iODS.WebApiService.Model
{
    public class AlarmLogSearchBaseModel
    {
        /// <summary>
        /// 标签名
        /// </summary>
        public string strTagName { get; set; }
        /// <summary>
        /// 标签描述
        /// </summary>
        public string strTagDesc { get; set; }
        /// <summary>
        /// 区域
        /// </summary>
        public string strArea { get; set; }
        /// <summary>
        /// 装置
        /// </summary>
        public string strDevice { get; set; }
        /// <summary>
        /// 单元
        /// </summary>
        public string strUnit { get; set; }
    }
}
