using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 隐藏报警设置
    /// </summary>
    [SugarTable("CF_HideAlarm")]
    public class HideAlarm : BaseEntity
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public string ID { get; set; }

        /// <summary>
        /// 报警类型（上限，上上限......）
        /// </summary>
        [SugarColumn(ColumnName = "nAlarmType")]
        public int AlarmType { get; set; }

        /// <summary>
        /// 标签名称
        /// </summary>
        [SugarColumn(ColumnName = "strTagName")]
        public string TagName { get; set; }

        /// <summary>
        /// 标签描述
        /// </summary>
        [SugarColumn(ColumnName = "strTagDes")]
        public string TagDes { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        [SugarColumn(ColumnName = "strOperater")]
        public string Operater { get; set; }

        /// <summary>
        /// 隐藏时间
        /// </summary>
        [SugarColumn(ColumnName = "strHideTime")]
        public System.DateTime HideTime { get; set; }
    }
}