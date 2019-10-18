using System;
using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 消息信息父表:通知消息数据表
    /// </summary>
    [SugarTable("SM_MessageInfo")]
    public class MessageInfo : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true,ColumnName = "ID")]
        public string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Sender { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? SendTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DelFlag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string InputCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? InputDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DeptCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CorpCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ModifyCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? ModifyDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? MsgType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "nPushStatus")]
        public int? PushStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? Client { get; set; }
    }
}