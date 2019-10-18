using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// PC节点进程下的驱动服务信息 ，非主表，无UUID
    /// </summary>
    [SugarTable("CF_ServiceState")]
    public class ServiceState : BaseEntity
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, ColumnName = "ID")]
        public string Id { get; set; }

        /// <summary>
        /// PC号	关联CF_ProcessState
        /// </summary>
        [SugarColumn(ColumnName = "nNodePCID")]
        public int NodePcid { get; set; }

        /// <summary>
        /// 状态 -1:初始化  0：不正常  1:正常  2:部分正常
        /// </summary>
        [SugarColumn(ColumnName = "nState")]
        public int State { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [SugarColumn(ColumnName = "strServiceName")]

        public string ServiceName { get; set; }

        /// <summary>
        /// 进程名称	关联CF_ProcessState
        /// </summary>
        [SugarColumn(ColumnName = "strProcessName")]

        public string ProcessName { get; set; }
    }
}