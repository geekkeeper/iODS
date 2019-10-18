using iODS.Model;

namespace iODS.WebApiService.Model
{
    public class PM_TrendGroupAndTagViewModel:TrendGroupAndTag
    {
        /// <summary>
        /// 标签点状态码 0:成功 1:点名不存在 2:参数错误 3:预留 4:超时
        /// </summary>
        public int lErrorNo { get; set; }

        public decimal nHighest { get; set; }

        public decimal nLowest { get; set; }

        /// <summary>
        /// 标签类型 0是布尔  7,8是模拟
        /// </summary>
        public string ulSType { get; set; }
    }
}
