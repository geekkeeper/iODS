using System;

namespace iODS.WebApiService.Model
{
    public class LogSearchModel:AlarmLogSearchBaseModel
    {
        /// <summary>
        /// 日志详情
        /// </summary>
        public string strContent { get; set; }
        /// <summary>
        /// 操作人
        /// </summary>
        public string strOperater { get; set; }
        /// <summary>
        /// 日志来源
        /// </summary>
        public string nLogSource { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime strBOperateTime { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime strEOperateTime { get; set; }
        /// <summary>
        /// 操作类型
        /// </summary>
        public string nOperateContentKey { get; set; }
        /// <summary>
        /// 项目架构编码
        /// </summary>
        public string strProjectCode { get; set; }
        /// <summary>
        /// 当前是第几页
        /// </summary>
        public int iCurPage { get; set; }
        /// <summary>
        /// 每页显示多少条
        /// </summary>
        public int iPageRowNum { get; set; }
        /// <summary>
        /// 页面资源编码串
        /// </summary>
        public string strOperateRoute { get; set; }
        /// <summary>
        /// 是否第一次查询 1是 0否
        /// </summary>
        public int IsFirstSearch { get; set; }
    }
}
