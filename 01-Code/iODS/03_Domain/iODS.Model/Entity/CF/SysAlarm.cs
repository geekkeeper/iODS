using System;
using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 系统报警信息
    /// </summary>
    [SugarTable("CF_SysAlarm")]
    public class SysAlarm : BaseEntity
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true,ColumnName = "ID")]
        public string Id { get; set; }

        /// <summary>
        /// 报警类型（上限，上上限......）
        /// </summary>
        [SugarColumn(ColumnName = "nAlarmType")]
        public int? AlarmType { get; set; }

        /// <summary>
        /// 报警状态
        /// </summary>
        [SugarColumn(ColumnName = "nAlarmState")]
        public int? AlarmState { get; set; }

        /// <summary>
        /// 报警级
        /// </summary>
        [SugarColumn(ColumnName = "nAlarmlevel")]
        public int? Alarmlevel { get; set; }

        /// <summary>
        /// 事件发生事件
        /// </summary>
        [SugarColumn(ColumnName = "strEventTime")]
        public DateTime? EventTime { get; set; }

        /// <summary>
        /// 标签名
        /// </summary>
        [SugarColumn(ColumnName = "strTagName")]
        public string TagName { get; set; }

        /// <summary>
        /// 标签描述
        /// </summary>
        [SugarColumn(ColumnName = "strTagDes")]
        public string TagDes { get; set; }

        /// <summary>
        /// 区域，为DCS日志设计
        /// </summary>
        [SugarColumn(ColumnName = "strArea")]
        public string Area { get; set; }

        /// <summary>
        /// 装置，为DCS日志设计
        /// </summary>
        [SugarColumn(ColumnName = "strDevice")]
        public string Device { get; set; }

        /// <summary>
        /// 单元,为DCS日志设计
        /// </summary>
        [SugarColumn(ColumnName = "strUnit")]
        public string Unit { get; set; }

        /// <summary>
        /// 事件信息描述
        /// </summary>
        [SugarColumn(ColumnName = "strMsgDes")]
        public string MsgDes { get; set; }

        /// <summary>
        /// 报警限
        /// </summary>
        [SugarColumn(ColumnName = "fAlarmlimit")]
        public double? Alarmlimit { get; set; }

        /// <summary>
        /// 报警时刻值
        /// </summary>
        [SugarColumn(ColumnName = "strAlarmValue")]
        public string AlarmValue { get; set; }

        /// <summary>
        /// 恢复事件
        /// </summary>
        [SugarColumn(ColumnName = "strRecoveryTime")]
        public DateTime? RecoveryTime { get; set; }

        /// <summary>
        /// 报警确认时间
        /// </summary>
        [SugarColumn(ColumnName = "strAckedTime")]
        public DateTime? AckedTime { get; set; }

        /// <summary>
        /// 报警确认信息
        /// </summary>
        [SugarColumn(ColumnName = "strAckedComment")]
        public string AckedComment { get; set; }

        /// <summary>
        /// 来源 1:DCS 2:ODS生产 3:ODS设备
        /// </summary>
        [SugarColumn(ColumnName = "nSource")]
        public int? Source { get; set; }

        /// <summary>
        /// 是否隐藏后产生0：非隐藏后生产 1：隐藏后生成
        /// </summary>
        [SugarColumn(ColumnName = "strIsHide")]
        public string IsHide { get; set; }

        /// <summary>
        /// 报警类型
        /// </summary>
        [SugarColumn(ColumnName = "strTypeName")]
        public string TypeName { get; set; }

        /// <summary>
        /// 报警类型描述
        /// </summary>
        [SugarColumn(ColumnName = "strAlarmTypeDes")]
        public string AlarmTypeDes { get; set; }

        /// <summary>
        /// 报警级别描述
        /// </summary>
        [SugarColumn(ColumnName = "strAlarmLevelDes")]
        public string AlarmLevelDes { get; set; }
    }
}