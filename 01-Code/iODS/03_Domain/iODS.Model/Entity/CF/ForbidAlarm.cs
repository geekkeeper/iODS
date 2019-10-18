using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 报警抑制表:抑制报警数据
    /// </summary>
    [SugarTable("CF_ForbidAlarm")]
    public class ForbidAlarm : BaseEntity
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
        /// 抑制时间
        /// </summary>
        [SugarColumn(ColumnName = "strForbidTime")]
        public System.DateTime ForbidTime { get; set; }
    }
}