using System;

namespace iODS.WebApiService.Model
{
    public class SM_ProjectGISViewModel
    {
        public string ID { get; set; }
        public string strProjectCode { get; set; }
        public decimal nLon { get; set; }
        public decimal nLat { get; set; }
        public string strIcon { get; set; }
        public int nDisplaySet { get; set; }
        public string strTagNames { get; set; }
        public string strRemark { get; set; }
        public string strDelFlag { get; set; }
        /// <summary>
        /// 是否报警 1报警 0未报警
        /// </summary>
        public int IsAlarm { get; set; }
        /// <summary>
        /// 项目架构名称
        /// </summary>
        public string strProjectName { get; set; }
        /// <summary>
        /// 报警级别
        /// </summary>
        public int nAlarmLevel { get; set; }
        private string _alarmLevelName = string.Empty;
        /// <summary>
        /// 报警ID
        /// add by wzg 20190410 
        /// </summary>
        public string alarmID { get; set; }
        /// <summary>
        /// 报警级别名称
        /// </summary>
        public string AlarmLevelName
        {
            get { return Enum.GetName(typeof(EComLib_AlarmLevelEnum), this.nAlarmLevel); }
            set { this._alarmLevelName = value; }
        }
        /// <summary>
        /// 报警状态
        /// </summary>
        public int nAlarmState { get; set; }
        private string _alarmStateName = string.Empty;
        /// <summary>
        /// 报警状态名称
        /// </summary>
        public string AlarmStateName
        {
            get { return Enum.GetName(typeof(EComLib_AlarmStateEnum), this.nAlarmState); }
            set { this._alarmStateName = value; }
        }
        /// <summary>
        /// 标签名
        /// </summary>
        public string strTagName { get; set; }
        /// <summary>
        /// 标签描述
        /// </summary>
        public string strDescription { get; set; }
        /// <summary>
        /// 是否选中
        /// </summary>
        public int IsChecked { get; set; }

        /// <summary>
        /// GTplus那边工程的guid
        /// </summary>
        public string strGTGuid { get; set; }
        /// <summary>
        /// 标签实时值
        /// </summary>
        public string nTagValue { get; set; }
    }
}
