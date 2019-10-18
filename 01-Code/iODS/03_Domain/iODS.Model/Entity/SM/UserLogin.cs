using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 用户登录记录表
    /// </summary>
    [SugarTable("SM_UserLogin")]
    public class UserLogin : BaseEntity
    {
        /// <summary>
        /// ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public string ID { get; set; }

        /// <summary>
        /// 用户登录帐号
        /// </summary>
        [SugarColumn(ColumnName = "strAccount")]
        public string Account { get; set; }

        /// <summary>
        /// 用户登录唯一标识
        /// </summary>
        [SugarColumn(ColumnName = "strUID")]
        public string UserID { get; set; }

        /// <summary>
        /// 用户登录时间
        /// </summary>
        [SugarColumn(ColumnName = "strLogTime")]
        public string LogTime { get; set; }

        /// <summary>
        /// 客户端最近请求时间
        /// </summary>
        [SugarColumn(ColumnName = "strLastReqTime")]
        public string LastReqTime { get; set; }

        /// <summary>
        /// 是否登陆，1登陆，0未登录
        /// </summary>
        public int IsOrNotLogin { get; set; }
    }
}