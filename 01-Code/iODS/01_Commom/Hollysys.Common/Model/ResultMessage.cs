namespace Hollysys.Common
{
    /// <summary>
    ///     通用接口返回信息类
    /// </summary>
    public class ResultMessage<T>
    {
        /// <summary>
        ///     操作结果：true成功，false失败
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        ///     返回信息
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 请求状态码
        /// </summary>
        public int StatusCode { get; set; }

        /// <summary>
        ///     返回的数据（json）
        /// </summary>
        public T Data { get; set; }
    }
}