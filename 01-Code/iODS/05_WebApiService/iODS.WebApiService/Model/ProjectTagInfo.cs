using System;
using System.Collections.Generic;

namespace iODS.WebApiService.Model
{
    public class ProjectTag_ViewModel
    {
        public string ID { get; set; }
        public string strID { get; set; }
        public string strName { get; set; }
        public string strDescription { get; set; }
        public string strArea { get; set; }
        public string strDevice { get; set; }
        public string strUnit { get; set; }
        public string strProjectCode { get; set; }
        public int nOrderNo { get; set; }
        public int nTagType { get; set; }
        public string strResourceUrl { get; set; }
        public string strGTGuid { get; set; }
        public string strGTPC { get; set; }
        public string strGTDomain { get; set; }
        public string strDelFlag { get; set; }
        public int nTagDataType { get; set; }
        public string strGTProjectName { get; set; }
    }


    public class ProjectTagInfo
    {
        public string ID { get; set; }
        public string strID { get; set; }
        public string strProjectCode{ get; set; }
        public  string nOrderNo{ get; set; }
        public string strDelFlag { get; set; }
        /// <summary>
        /// 标签名称
        /// </summary>
        public string strName { get; set; }
        /// <summary>
        /// 标签描述
        /// </summary>
        public string strDescription { get; set; }
        /// <summary>
        /// 标签资源地址
        /// </summary>
        public string strResourceUrl { get; set; }
        /// <summary>
        /// 标签归属工程标识
        /// </summary>
        public string strGTGuid { get; set; }
        /// <summary>
        /// 实时库名称
        /// </summary>
        public string strRTDBName { get; set; }
        /// <summary>
        /// 标签归属PC标识
        /// </summary>
        public string strGTPC { get; set; }
        /// <summary>
        /// 标签归属域名标识
        /// </summary>
        public string strGTDomain { get; set; }
        /// <summary>
        /// 标签类型
        /// </summary>
        public TagType nTagType { get; set; }

        /// <summary>
        /// 标签类型
        /// </summary>
        public string strTagType
        {
            get => Enum.GetName(typeof(TagType), this.nTagType);
            set {
                if (!string.IsNullOrEmpty(value))
                {
                    this.nTagType = (TagType) Enum.Parse(typeof(TagType),value);
                }
            }
        }
        /// <summary>
        /// 标签数据类型
        /// </summary>
        //[JsonConverter(typeof(StringEnumConverter))]
        public TagDataType nTagDataType { get; set; }

        /// <summary>
        /// 标签数据类型
        /// </summary>
        public string strTagDataType
        {
            get=>Enum.GetName(typeof(TagDataType), this.nTagDataType);
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.nTagDataType = (TagDataType) Enum.Parse(typeof(TagDataType),value);
                }
            }
        }

        /// <summary>
        /// 区域
        /// </summary>
        public string strArea { get; set; }
        /// <summary>
        /// 装置
        /// </summary>
        public string strDevice { get; set; }
        /// <summary>
        /// 单元
        /// </summary>
        public string strUnit { get; set; }
    }

    /// <summary>
    /// 标签数据类型
    /// </summary>
    public enum TagDataType
    {
        BOOL,
        BYTE,
        WORD,
        DWORD,
        SBYTE,
        SWORD,
        SDWORD,
        SINGLE,
        DOUBLE,
        ALM_BOOL,
        ALM_BYTE,
        ALM_WORD,
        ALM_DWORD,
        ALM_SBYTE,
        ALM_SWORD,
        ALM_SDWORD,
        ALM_SINGLE,
        ALM_DOUBLE,
        STRING,
        COLOR,
        IP,
        FONT,
        MEMBLCOK,
        BIT1,
        BITS2,
        BITS4,
        BWORD,
        BDWORD,
        BSWORD,
        BSDWORD,
        BSINGLE,
        BDOUBLE,
        DS,
        DSM6,
        AS_INT1,
        AS_INT2,
        AS_INT4,
        AS_REAL,
        AI,
        AO,
        DI,
        DO,
        BYTES8
    }

    public class TagCatalogModel
    {
        public string strGTGuid { get; set; }
        public string strGTProjectName { get; set; }
        public string strPCName { get; set; }
        public string strRTDBName { get; set; }
    }

    public class AddTagForPC
    {
        public string strGTGuid { get; set; }
        public string strPCName { get; set; }
        public string strRTDBName { get; set; }
    }

    public class AddTagParam
    {
        /// <summary>
        /// 工程编码
        /// </summary>
        public string strProjectCode { get; set; }
        /// <summary>
        /// 数据添加类型
        /// </summary>
        public int nInsertType { get; set; }
        /// <summary>
        /// 实时库列表
        /// </summary>
        public List<AddTagForPC> lstAddForPC { get; set; }
        /// <summary>
        /// 标签信息列表
        /// </summary>
        public List<ProjectTagInfo> lstAddForTagInfo { get; set; }
    }

    public enum QueryTagType
    {
        /// <summary>
        /// 根据实时库查询
        /// </summary>
        ForRtdb = 1,
        /// <summary>
        /// 查询特殊标签
        /// </summary>
        ForSpecialTag = 2,
        /// <summary>
        /// 查询普通标签
        /// </summary>
        ForNormalTag = 3
    }

    public enum TagType
    {
        普通标签 = 0,
        特殊标签 = 1
    }

    public enum TagInsertType
    {
        /// <summary>
        /// 清空添加
        /// </summary>
        Clear = 0,
        /// <summary>
        /// 增量添加
        /// </summary>
        Addition = 1
    }
}
