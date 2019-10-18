using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 用户系统资源操作权限表
    /// </summary>
    [SugarTable("SM_PersonSysPower")]
    public class PersonSysPower : BaseEntity
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
        [SugarColumn(ColumnName = "PageButtonConfigID")]
        public int PageButtonConfigId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string IsEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnName = "strIsEnable")]
        public string Enable { get; set; }
    }
}