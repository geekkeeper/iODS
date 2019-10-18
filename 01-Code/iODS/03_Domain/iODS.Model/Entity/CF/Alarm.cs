using System;
using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 表名缩写含义： CF：计算服务； PM：生产监视； SM： 系统设置
    /// 报警表:生产报警信息
    /// </summary>
    [SugarTable("CF_Alarm")]
    public class Alarm : BaseEntity
    {
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true,ColumnName = "ID")]
        public string Id { get; set; }
        
        /// <summary>
        /// 报警类型（上限，上上限......）
        /// </summary>
        [SugarColumn(ColumnName = "nAlarmType")]
        public int? AlarmType { get; set; } = default;

        /// <summary>
        /// 报警状态
        /// </summary>
        [SugarColumn(ColumnName = "nAlarmState")]
        public int? AlarmState { get; set; }

        /// <summary>
        /// 报警级别
        /// </summary>
        [SugarColumn(ColumnName = "nAlarmlevel")]
        public int? AlarmLevel { get; set; }

        /// <summary>
        /// 报警时间
        /// </summary>
        [SugarColumn(ColumnName = "strEventTime")]
        public DateTime? EventTime { get; set; }

        /// <summary>
        /// 标签名称
        /// </summary>
        [SugarColumn(ColumnName = "strTagName")]
        public string TagName { get; set; }

        /// <summary>
        /// 标签描述
        /// </summary>
        [SugarColumn(ColumnName = "strTagDes")]
        public string TagDescription { get; set; }

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
        /// 报警描述
        /// </summary>
        [SugarColumn(ColumnName = "strMsgDes")]
        public string MsgDes { get; set; }

        /// <summary>
        /// 报警阀值
        /// </summary>
        [SugarColumn(ColumnName = "fAlarmlimit")]
        public double? AlarmLimit { get; set; }

        /// <summary>
        /// 报警实时值
        /// </summary>
        [SugarColumn(ColumnName = "strAlarmValue")]
        public string AlarmValue { get; set; }

        /// <summary>
        /// 恢复时间
        /// </summary>
        [SugarColumn(ColumnName = "strRecoveryTime")]
        public DateTime? RecoveryTime { get; set; }

        /// <summary>
        /// 确认时间
        /// </summary>
        [SugarColumn(ColumnName = "strAckedTime")]
        public DateTime? AckedTime { get; set; }

        /// <summary>
        /// 恢复内容
        /// </summary>
        [SugarColumn(ColumnName = "strAckedComment")]
        public string AckedComment { get; set; }

        /// <summary>
        /// 报警来源
        /// </summary>
        [SugarColumn(ColumnName = "nSource")]
        public int? Source { get; set; }

        /// <summary>
        /// 是否隐藏后产生0：非隐藏后生产 1：隐藏后生成
        /// </summary>
        [SugarColumn(ColumnName = "strIsHide")]
        public string IsHide { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "strNodeDomain")]
        public string NodeDomain { get; set; }

        /// <summary>
        /// 报警类型
        /// </summary>
        [SugarColumn(ColumnName = "strTypeName")]
        public string TypeName { get; set; }

        /// <summary>
        /// 报警类型描述
        /// </summary>
        [SugarColumn(ColumnName = "strAlarmTypeDes")]
        public string AlarmTypeDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "nPushStatus")]
        public int? PushStatus { get; set; }

        /// <summary>
        /// 报警级别描述
        /// </summary>
        [SugarColumn(ColumnName = "strAlarmLevelDes")]
        public string AlarmLevelDescription { get; set; }
    }
}