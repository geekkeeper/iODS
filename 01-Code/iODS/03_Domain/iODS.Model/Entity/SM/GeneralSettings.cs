using SqlSugar;

namespace iODS.Model
{
    /// <summary>
    /// 
    /// </summary>
    [SugarTable("SM_GeneralSettings")]
    public class GeneralSettings : BaseEntity
    {
        /// <summary>
        /// 主键，guid
        /// </summary>
        [SugarColumn(IsPrimaryKey = true,ColumnName = "ID")]
        public string Id { get; set; }

        /// <summary>
        /// 报警声音轮询条数设置，默认3
        /// </summary>
        public int AlarmVoiceCycleNum { get; set; }

        /// <summary>
        /// 连接中断时间设置，单位分钟
        /// </summary>
        public int ConnInterruptTime { get; set; }

        /// <summary>
        /// 无操作注销时间设置，单位分钟
        /// </summary>
        public int LogoutTime { get; set; }

        /// <summary>
        /// 密码失效时间设置，单位月
        /// </summary>
        public int PassWordInValidTime { get; set; }

        /// <summary>
        /// 版权和网络备案号
        /// </summary>
        public string NetworkRecordNumber { get; set; }

        /// <summary>
        /// 登陆页背景图设置，存储文件流
        /// </summary>
        public byte[] LoginBackGroundPicture { get; set; }

        /// <summary>
        /// 主界面logo设置
        /// </summary>
        public byte[] MainLogoPicture { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public System.DateTime CreateTime { get; set; }

        /// <summary>
        /// 修改设置时间
        /// </summary>
        public System.DateTime ModifiedTime { get; set; }

        /// <summary>
        /// 主页背景图片
        /// </summary>
        public byte[] HomeBackgroundPicture { get; set; }
    }
}