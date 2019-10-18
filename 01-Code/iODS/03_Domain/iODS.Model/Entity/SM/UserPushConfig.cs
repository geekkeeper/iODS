using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// APP推送状态：手机APP相关
    /// </summary>
    [SugarTable("SM_UserPushConfig")]
    public class UserPushConfig : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public string ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "strPersonCode")]
        public string PersonCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "dtAlarmPushLastTime")]
        public System.DateTime? AlarmPushLastTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "dtNotifyPushLastTime")]
        public System.DateTime? NotifyPushLastTime { get; set; }
    }
}