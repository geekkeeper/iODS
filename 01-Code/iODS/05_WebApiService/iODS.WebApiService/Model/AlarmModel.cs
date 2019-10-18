using System;

namespace iODS.WebApiService.Model
{
    public class ConfirmManyModel
    {
        /// <summary>
        /// 确认报警ID列表
        /// </summary>
        public string ids { get; set; }
        /// <summary>
        /// 确认报警备注信息
        /// </summary>
        public string strMark { get; set; }
    }

    public class ConfirmProjectModel
    {
        /// <summary>
        /// 确认报警ID列表
        /// </summary>
        public string strProjectCode { get; set; }

        /// <summary>
        /// 确认报警备注信息
        /// </summary>
        public string strMark { get; set; }
    }

    public class FilterQueryModel: AlarmLogSearchBaseModel
    {
        public string ProjectCode { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public string SourceArray { get; set; }
        public string LevelArray { get; set; }
        public string StatusArray { get; set; }
        public string AlarmTypeArray { get; set; }
        public string sWhere { get; set; }
        public string sOrder { get; set; }
        public int iCurPage { get; set; }
        public int iPageRowNum { get; set; }
    }

    public class AlarmConfigModel
    {
        public string strTagName { get; set; }
        public string strTagDes { get; set; }
        public string strAlarmTypeArray { get; set; }
    }

    public class ConfigParam
    {
        public string strTagName { get; set; }
        public string strTagDes { get; set; }
        public int nAlarmType { get; set; }
    }

    public class AlarmVoiceQueryModel
    {
        public string strTagName { get; set; }
        public int nAlarmState { get; set; }
        public int nAlarmlevel { get; set; }
        public string strAlarmTypeDes { get; set; }
        public string strAlarmLevelDes { get; set; }
        public DateTime strEventTime { get; set; }
        public string strNodeDomain { get; set; }
        public string strProjectName { get; set; }
        public string strProjectCode { get; set; }
        public int nSource { get; set; }
    }
}
