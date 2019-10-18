namespace iODS.WebApiService.Model
{
    public class SM_LogViewModel
    {
        public string strOperater { get; set; }
        public string strOperateTime { get; set; }
        public string strLabelName { get; set; }
        public string strLabelDescribe { get; set; }
        public int nLogSource { get; set; }
        public string strLogSourceName { get; set; }
        public string strOperateRoute { get; set; }
        public string strOperateRouteName { get; set; }
        public int nOperateContentKey { get; set; }
        public string strOperateContent { get; set; }
        public string strContent { get; set; }
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
        public int nStatus { get; set; }
    }
}
