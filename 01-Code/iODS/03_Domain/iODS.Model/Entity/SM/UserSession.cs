using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// APP用户会话表:手机APP用户登录在线离线记录表
    /// </summary>
    [SugarTable("SM_UserSession")]
    public class UserSession : BaseEntity
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
        [SugarColumn(ColumnName = "strSessionID")]
        public string SessionID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "strLastUpdateTime")]
        public string LastUpdateTime { get; set; }
    }
}