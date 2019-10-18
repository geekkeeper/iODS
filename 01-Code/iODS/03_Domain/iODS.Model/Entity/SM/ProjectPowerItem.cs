using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 项目架构树授权项配置表
    /// </summary>
    [SugarTable("SM_ProjectPowerItem")]
    public class   ProjectPowerItem : BaseEntity
    {
        /// <summary>
        /// 项目架构项ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public string ID { get; set; }

        /// <summary>
        /// 项目架构项编码
        /// </summary>
        [SugarColumn(ColumnName = "strCode")]
        public string Code { get; set; }

        /// <summary>
        /// 项目架构项名称
        /// </summary>
        [SugarColumn(ColumnName = "strName")]
        public string Name { get; set; }

        /// <summary>
        /// 项目架构项序号
        /// </summary>
        [SugarColumn(ColumnName = "nOrderNo")]
        public int? OrderNo { get; set; }

        /// <summary>
        /// 虚拟项类型（0：非虚拟项， 1： 普通单虚拟项， 2： 组虚拟项）
        /// </summary>
        [SugarColumn(ColumnName = "nVirtualItemType")]
        public int? VirtualItemType { get; set; }

        /// <summary>
        /// 是否可以设置对应权限
        /// </summary>
        [SugarColumn(ColumnName = "nIsCanPowerItem")]
        public int? IsCanPowerItem { get; set; }
    }
}