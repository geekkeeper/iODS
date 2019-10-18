using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 日志操作类型字典表：操作类型key,value对应表
    /// </summary>
    [SugarTable("SM_OperateContent")]
    public class OperateType : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "ID")]
        public string Id { get; set; }

        /// <summary>
        /// 操作类型的key
        /// </summary>
        [SugarColumn(IsPrimaryKey = true,ColumnName = "nOperateContentKey")]
        public string OperateContentKey { get; set; }

        /// <summary>
        /// 操作类型key对应的汉字
        /// </summary>
        
        [SugarColumn(ColumnName = "strOperateContent")] 
        public string OperateContent { get; set; }
    }
}