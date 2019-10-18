using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 手机APP系统设置表
    /// </summary>
    [SugarTable("SM_SysSetting")]
    public class SysSetting : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public string ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "strKey")]
        public string Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "strValue")]
        public string Value { get; set; }
    }
}