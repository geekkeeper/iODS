using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 
    /// </summary>
    [SugarTable("SM_Role")]
    public class Role : BaseEntity
    {
        /// <summary>
        /// 角色表
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public string ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Describe { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string DelFlag { get; set; }
    }
}