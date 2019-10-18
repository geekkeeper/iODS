using iODS.Model;

namespace iODS.WebApiService.Model
{
    public class CF_HideAlarmViewModel : HideAlarm
    {
        public string strArea { get; set; }
        public string strDevice { get; set; }
        public string strUnit { get; set; }
    }
}
