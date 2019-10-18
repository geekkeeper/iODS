using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 角色系统资源数据权限表
    /// </summary>
    [SugarTable("SM_RoleDataPower")]
    public class RoleDataPower : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public string ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string RoleCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string SystemResourceDtlCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DataPower { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CustomPower { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "strIsEnable")]
        public string IsEnable { get; set; }
    }
}