using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 项目架构树和Gis关系表
    /// </summary>
    [SugarTable("SM_ProjectGIS")]
    public class ProjectGIS : BaseEntity
    {
        /// <summary>
        /// 趋势组ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true,ColumnName = "ID")]
        public string Id { get; set; }

        /// <summary>
        /// 项目架构编码
        /// </summary>
        [SugarColumn(ColumnName = "strProjectCode")]
        public string ProjectCode { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [SugarColumn(ColumnName = "nLon")]
        public decimal Lon { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [SugarColumn(ColumnName = "nLat")]
        public decimal Lat { get; set; }

        /// <summary>
        /// 图标的名字
        /// </summary>
        [SugarColumn(ColumnName = "strIcon")]
        public string Icon { get; set; }

        /// <summary>
        /// 始终显示1  鼠标放上显示2
        /// </summary>
        [SugarColumn(ColumnName = "nDisplaySet")]
        public int DisplaySet { get; set; }

        /// <summary>
        /// 标签名称集合
        /// </summary>
        [SugarColumn(ColumnName = "strTagNames")]
        public string TagNames { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [SugarColumn(ColumnName = "strRemark")]
        public string Remark { get; set; }

        /// <summary>
        /// 删除标志 1删除  0未删除
        /// </summary>
        [SugarColumn(ColumnName = "strDelFlag")]
        public string DelFlag { get; set; }
    }
}