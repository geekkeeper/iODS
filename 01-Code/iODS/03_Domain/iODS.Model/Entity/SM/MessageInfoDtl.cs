using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 消息信息子表:通知消息详细数据表
    /// </summary>
    [SugarTable("SM_MessageInfoDtl")]
    public class MessageInfoDtl : BaseEntity
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true,ColumnName = "ID")]
        public string Id { get; set; }

        /// <summary>
        /// 父ID
        /// </summary>
        [SugarColumn(ColumnName = "PID")]
        public string ParentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PersonCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string IsRead { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DelFlag { get; set; }
    }
}