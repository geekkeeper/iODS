using System.Collections.Generic;

namespace iODS.WebApiService.Model
{
    /// <summary>
    /// 作者：牛文杰
    /// 创始时间：2018年10月11日14点37分
    /// 描述：流程图项目架构树
    /// </summary>
    public class ProjectPowerTreeModel
    {
        /// <summary>
        /// 项目架构树编码
        /// </summary>
        public string strCode { get; set; } = "";
        /// <summary>
        /// 父级节点code
        /// </summary>
        public string strPCode { get; set; } = "";
        /// <summary>
        /// 权限项显示名字
        /// </summary>
        public string strName { get; set; } = "";
        /// <summary>
        /// 权限项编码
        /// </summary>
        public int nIsCanPowerItem { get; set; } = 0;
        /// <summary>
        /// 节点唯一标识
        /// </summary>
        public string strItemID { get; set; } = "";
        /// <summary>
        /// 项目架构树节点编码
        /// </summary>
        public string strProjectCode { get; set; } = "";
        /// <summary>
        /// 授权类编码(FlowChart，GISMap，Alarm）
        /// </summary>
        public string strPowerCode { get; set; } = "";
        /// <summary>
        /// 非虚拟权限项 0， 普通单项虚拟项 1，  （group)虚拟项 2
        /// </summary>
        public int nIsVirtualItem { get; set; } = 0;
        /// <summary>
        /// 序号
        /// </summary>
        public int nOrderNo { get; set; } = 1;
    }

    public class PowerData
    {
        public string DataPowerIDs { get; set; }
        public string DataPowers { get; set; }
        public string SysPowerIDs { get; set; }
        public string SysPowers { get; set; }

        public string ProjectDataPowerIDs { get; set; }
        public string ProjectDataPowers { get; set; }
        public string ProjectSysPowerIDs { get; set; }
        public string ProjectSysPowers { get; set; }
        public string PersonOrRole { get; set; }
    }

    public class ProjectSysButton
    {
        public string strProjectCode { get; set; }
        public string strItem { get; set; }
        public string strBtnIDList { get; set; }
    }

    //------------------new Query interface
    public class SysPowerModel
    {
        public Dictionary<string, SysGroupInfo> strProjectCodeToGroupInfo { get; set; }
    }

    public class SysGroupInfo
    {
        public Dictionary<string, SysItemInfo> strGroupIDToItemInfo { get; set; }
    }

    public class SysItemInfo
    {
        public Dictionary<string, SysElement> strItemIDToSysElement { get; set; }
    }

    public class SysElement
    {
        public string strItemID { get; set; }
        public string strItemName { get; set; }
        public string strProjectCode { get; set; }
        public string strGroupID { get; set; }
        public Dictionary<string, BtnInfo> strBtnIDToBtnInfo { get; set; }
    }

    public class BtnInfo
    {
        public string ID { get; set; } = "-1";
        public int Status { get; set; } = 0;
        public string Enable { get; set; } = "1";
        public string BtnID { get; set; }
        public string BtnName { get; set; }
        public int BtnPowerType { get; set; }
    }

    /// <summary>  
    /// 操作权限用户与角色兼容信息类
    /// ProjectSysBtnInfo
    /// </summary> 
    public class ProjectSysBtnInfo
    {
        public string ID { get; set; }
        public string strButtonID { get; set; }
        public string strButtonName { get; set; }
        public string strProjectSysPowerCode { get; set; }
        public int nPowerCodeType { get; set; }
        public string strProjectCode { get; set; }
        public string strItemCode { get; set; }
        public int nPageButtonConfigID { get; set; }
        public string strIsEnable { get; set; } = "1";

    }
    //-----------------
}
