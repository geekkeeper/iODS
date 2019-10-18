using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 用户配置:与用户相关的配置，“报警消音”， “报警灯记时”
    /// </summary>
    [SugarTable("SM_UserConfig")]
    public class UserConfig : BaseEntity
    {
        /// <summary>
        /// 用户配置项ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public string ID { get; set; }

        /// <summary>
        /// 配置关联用户编码
        /// </summary>
        [SugarColumn(ColumnName = "strPersonCode")]
        public string PersonCode { get; set; }

        /// <summary>
        /// 报警消音开关（0：开启， 1：关闭）
        /// </summary>
        public string AlarmVoiceOff { get; set; }

        /// <summary>
        /// 报警灯时间戳
        /// </summary>
        [SugarColumn(ColumnName = "strAlarmLightTime")]
        public System.DateTime? AlarmLightTime { get; set; }
    }
}