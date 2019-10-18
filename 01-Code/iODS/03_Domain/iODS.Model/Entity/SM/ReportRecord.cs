using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 报表记录表
    /// </summary>
    [SugarTable("SM_ReportRecord")]
    public class ReportRecord : BaseEntity
    {
        /// <summary>
        /// 自增id
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public string ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PID { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime strInputDate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public System.DateTime strModifyDate { get; set; }

        /// <summary>
        /// 报表名称(带生成时间)
        /// </summary>
        public string strReportNameAndTime { get; set; }

        /// <summary>
        /// 执行人（自动报表为空）
        /// </summary>
        public string strOperatorAccount { get; set; }

        /// <summary>
        /// 删除标志  1删除  0未删除
        /// </summary>
        public int strDelFlag { get; set; }
    }
}