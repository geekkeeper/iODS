namespace iODS.WebApiService.Model
{
    public class ProjectOwnTreeModel
    {
        /// <summary>
        /// 标签父归属标识
        /// </summary>
        public string strPCode { get; set; }
        /// <summary>
        /// 标签归属唯一ID
        /// </summary>
        public string strGTGuid { get; set; }
        /// <summary>
        /// 归属名称
        /// </summary>
        public string strGTName { get; set; }
    }

    public class QueryProjectItemModel
    {
        public string strGTGuid { get; set; }
        public int iCurPage { get; set; }
        public int iPageRowNum { get; set; }
    }
}
