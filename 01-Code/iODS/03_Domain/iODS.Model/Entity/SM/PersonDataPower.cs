using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 用户系统资源数据权限表
    /// </summary>
    [SugarTable("SM_PersonDataPower")]
    public class PersonDataPower : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(IsPrimaryKey = true,ColumnName = "ID")]
        public string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PersonCode { get; set; }

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