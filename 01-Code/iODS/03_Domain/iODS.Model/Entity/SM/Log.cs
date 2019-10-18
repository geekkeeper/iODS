using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 日志表
    /// </summary>
    [SugarTable("SM_Log")]
    public class Log : BaseEntity
    {
        /// <summary>
        /// 自增序号
        /// </summary>
        [SugarColumn(IsPrimaryKey = true,ColumnName = "ID")]
        public string Id { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [SugarColumn(ColumnName = "strOperater")]
        public string Operater { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [SugarColumn(ColumnName = "strOperateTime")]
        public System.DateTime OperateTime { get; set; }

        /// <summary>
        /// 日志来源 生产日志 = 1,系统日志 = 2,DCS日志 = 3
        /// </summary>
        [SugarColumn(ColumnName = "nLogSource")]
        public int LogSource { get; set; }

        /// <summary>
        ///  其他0，登录注销1、新增2、删除3、修改4，置位 = 10,写模拟量值 = 11,
        /// </summary>
        [SugarColumn(ColumnName = "nOperateContentKey")]
        public int OperateContentKey { get; set; }

        /// <summary>
        /// 状态 1成功  0失败
        /// </summary>
        [SugarColumn(ColumnName = "nStatus")]
        public int Status { get; set; }

        /// <summary>
        /// ip
        /// </summary>
        [SugarColumn(ColumnName = "strIP")]
        public string Ip { get; set; }

        /// <summary>
        /// 标签名
        /// </summary>
        [SugarColumn(ColumnName = "strLabelName")]
        public string LabelName { get; set; }

        /// <summary>
        /// 标签描述
        /// </summary>
        [SugarColumn(ColumnName = "strLabelDescribe")]
        public string LabelDescribe { get; set; }

        /// <summary>
        /// 区域，为DCS日志设计
        /// </summary>
        [SugarColumn(ColumnName = "strArea")]
        public string Area { get; set; }

        /// <summary>
        /// 装置，为DCS日志设计
        /// </summary>
        [SugarColumn(ColumnName = "strDevice")]
        public string Device { get; set; }

        /// <summary>
        /// 单元,为DCS日志设计
        /// </summary>
        [SugarColumn(ColumnName = "strUnit")]
        public string Unit { get; set; }

        /// <summary>
        /// 页面编码或者流程图id
        /// </summary>
        [SugarColumn(ColumnName = "strOperateRoute")]
        public string OperateRoute { get; set; }

        /// <summary>
        /// 修改前值
        /// </summary>
        [SugarColumn(ColumnName = "strPreContent")]
        public string PreContent { get; set; }

        /// <summary>
        /// 修改后值
        /// </summary>
        [SugarColumn(ColumnName = "strafterContent")]
        public string AfterContent { get; set; }

        /// <summary>
        /// 日志详情
        /// </summary>
        [SugarColumn(ColumnName = "strContent")]
        public string Content { get; set; }
    }
}