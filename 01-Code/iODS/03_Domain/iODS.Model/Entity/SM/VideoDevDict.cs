using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 云视频设备表
    /// </summary>
    [SugarTable("SM_VideoDevDict")]
    public class VideoDevDict : BaseEntity
    {
        /// <summary>
        /// 视频设备类型ID
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// 视频设备类型
        /// </summary>
        [SugarColumn(ColumnName = "strDeviceType")]
        public string DeviceType { get; set; }
    }
}