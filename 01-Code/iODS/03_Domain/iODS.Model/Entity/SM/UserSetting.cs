using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// APP用户设置:手机APP用户设置
    /// </summary>
    [SugarTable("SM_UserSetting")]
    public class UserSetting : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public string ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "strAccount")]
        public string Account { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "bEnablePush")]
        public bool? EnablePush { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "bEnableAlarmPush")]
        public bool? EnableAlarmPush { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "nAlarmPushLevel")]
        public int? AlarmPushLevel { get; set; }
    }
}