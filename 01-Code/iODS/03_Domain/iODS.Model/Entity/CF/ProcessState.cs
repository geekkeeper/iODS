using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 节点PC下的进程状态信息，非主表，无UUID
    /// </summary>
    [SugarTable("CF_ProcessState")]
    public class ProcessState : BaseEntity
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true,ColumnName = "ID")]
        public string Id { get; set; }

        /// <summary>
        /// 进程ID
        /// </summary>
        [SugarColumn(ColumnName = "nProcessID")]
        public int ProcessId { get; set; }

        /// <summary>
        /// PC号	关联表CF_NodeState
        /// </summary>
        [SugarColumn(ColumnName = "nNodePCID")]
        public int NodePcid { get; set; }

        /// <summary>
        /// 状态 -1:初始化  0：不正常  1:正常
        /// </summary>
        [SugarColumn(ColumnName = "nState")]
        public int State { get; set; }

        /// <summary>
        /// 进程名
        /// </summary>
        [SugarColumn(ColumnName = "strProcessName")]
        public string ProcessName { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [SugarColumn(ColumnName = "strStateTime")]
        public System.DateTime StateTime { get; set; }
    }
}