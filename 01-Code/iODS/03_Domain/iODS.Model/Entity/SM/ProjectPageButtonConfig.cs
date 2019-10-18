using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 项目架构树按钮配置表
    /// </summary>
    [SugarTable("SM_ProjectPageButtonConfig")]
    public class ProjectPageButtonConfig : BaseEntity
    {
        /// <summary>
        /// 唯一ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public string ID { get; set; }

        /// <summary>
        /// 归属操作权限Code
        /// </summary>
        [SugarColumn(ColumnName = "strProjectSysPowerCode")]
        public string ProjectSysPowerCode { get; set; }

        /// <summary>
        /// 按钮ID
        /// </summary>
        [SugarColumn(ColumnName = "strButtonID")]
        public string ButtonID { get; set; }

        /// <summary>
        /// 按钮名称
        /// </summary>
        [SugarColumn(ColumnName = "strButtonName")]
        public string ButtonName { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [SugarColumn(ColumnName = "strRemark")]
        public string Remark { get; set; }

        /// <summary>
        /// 操作权限类型
        /// </summary>
        [SugarColumn(ColumnName = "nPowerCodeType")]
        public int? PowerCodeType { get; set; }
    }
}