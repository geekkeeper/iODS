using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 视频帐号表
    /// </summary>
    [SugarTable("")]
    public class VideoAccount : BaseEntity
    {
        /// <summary>
        /// 视频帐户ID
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// 视频帐户名称
        /// </summary>
        [SugarColumn(ColumnName = "strAccountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// AppKey
        /// </summary>
        [SugarColumn(ColumnName = "strAppKey")]
        public string AppKey { get; set; }

        /// <summary>
        /// AppSecret
        /// </summary>
        [SugarColumn(ColumnName = "strAppSecret")]
        public string AppSecret { get; set; }
    }
}