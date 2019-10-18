using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 组态节点状态信息
    /// </summary>
    [SugarTable("CF_NodeState")]
    public class NodeState : BaseEntity
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true,ColumnName = "ID")]
        public string Id { get; set; }

        /// <summary>
        /// CPU负荷
        /// </summary>
        [SugarColumn(ColumnName = "nCPULoad")]
        public int CpuLoad { get; set; }

        /// <summary>
        /// 温度
        /// </summary>
        [SugarColumn(ColumnName = "fTemperature")]
        public double Temperature { get; set; }

        /// <summary>
        /// 内存负荷
        /// </summary>
        [SugarColumn(ColumnName = "nMemoryLoad")]
        public int MemoryLoad { get; set; }

        /// <summary>
        /// 状态 -1:初始化  0：不正常  1:正常
        /// </summary>
        [SugarColumn(ColumnName = "nState")]
        public int State { get; set; }

        /// <summary>
        /// 节点类型（0普通节点，1网闸安全侧，2网闸开放侧，3云卡）
        /// </summary>
        [SugarColumn(ColumnName = "nNodeType")]
        public int NodeType { get; set; }

        /// <summary>
        /// PC号
        /// </summary>
        [SugarColumn(ColumnName = "nNodePCID")]
        public int? NodePcid { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [SugarColumn(ColumnName = "strStateTime")]
        public System.DateTime StateTime { get; set; }

        /// <summary>
        /// 网闸序列号
        /// </summary>
        [SugarColumn(ColumnName = "strSerialNum")]
        public string SerialNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "fNetworkALoad")]
        public double? NetworkALoad { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "fNetworkBLoad")]
        public double? NetworkBLoad { get; set; }
    }
}