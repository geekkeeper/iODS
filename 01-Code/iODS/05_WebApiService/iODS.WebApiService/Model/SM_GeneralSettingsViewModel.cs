using System;

namespace iODS.WebApiService.Model
{
    public class SM_GeneralSettingsViewModel
    {
        public string ID { get; set; }
        public int AlarmVoiceCycleNum { get; set; }
        public int ConnInterruptTime { get; set; }
        public int LogoutTime { get; set; }
        public int PassWordInValidTime { get; set; }
        public string NetworkRecordNumber { get; set; }
        public string ICPCertificateNo { get; set; }
        public string LoginBackGroundPicture { get; set; }
        public string MainLogoPicture { get; set; }
        public string HomeBackgroundPicture { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime ModifiedTime { get; set; }
        public string PassWordOverDueTime { get; set; }
        /// <summary>
        /// 密码过期是否提醒 1提醒 0不提醒
        /// </summary>
        public int IsPassWordRemind { get; set; }
        /// <summary>
        /// 距离密码过期的天数 0是当天，小于0是已经过期了，大于0是还有多少天过期
        /// </summary>
        public int PassWordExpiredDays { get; set; }
    }
}