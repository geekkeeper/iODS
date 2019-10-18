using System;

namespace iODS.WebApiService.Model
{
    public class SysAlarmViewModel
    {
        public string ID { get; set; }
        public int nAlarmType { get; set; }
        public int nAlarmState { get; set; }
        public int nAlarmlevel { get; set; }
        public DateTime strEventTime { get; set; }
        public string strTagName { get; set; }
        public string strTagDes { get; set; }
        public string strMsgDes { get; set; }
        public double fAlarmlimit { get; set; }
        public string strAlarmValue { get; set; }
        public DateTime strRecoveryTime { get; set; }
        public DateTime strAckedTime { get; set; }
        public string strAckedComment { get; set; }
        public int nSource { get; set; }
        public string strIsHide { get; set; }

        private string _alarmLevelName = string.Empty;
        /// <summary>
        /// 报警级别名称
        /// </summary>
        public string AlarmLevelName
        {
            get { return Enum.GetName(typeof(EComLib_AlarmLevelEnum), this.nAlarmlevel); }
            set { this._alarmLevelName = value; }
        }

        private string _alarmStateName = string.Empty;
        /// <summary>
        /// 报警状态名称
        /// </summary>
        public string AlarmStateName
        {
            get { return Enum.GetName(typeof(EComLib_AlarmStateEnum), this.nAlarmState); }
            set { this._alarmStateName = value; }
        }

        private string _alarmTypeName = string.Empty;
        /// <summary>
        /// 报警类型名称
        /// </summary>
        public string AlarmTypeName
        {
            get { return Enum.GetName(typeof(ComLib_AlarmTypeEnum), this.nAlarmType); }
            set { this._alarmTypeName = value; }
        }
    }
    
    public enum EComLib_AlarmLevelEnum
    {
        一级 = 1,
        二级 = 2,
        三级 = 3,
        四级 = 4,
        五级 = 5,
        六级 = 6,
        七级 = 7,
        八级 = 8,
        九级 = 9,
        十级 = 10,
    }
    public enum EComLib_AlarmStateEnum
    {
        未恢复未确认 = 1,
        已恢复未确认 = 2,
        未恢复已确认 = 3,
        已恢复已确认 = 4,
    }
    
    /// <summary>
    /// 报警类型
    /// </summary>
    public enum ComLib_AlarmTypeEnum
    {
        高高限报警 = 1,
        高限报警  = 3,  
        低限报警  = 5,
        低低限报警 =7,  
        闭合报警  = 9,   
        断开报警  = 11,
    }
}
