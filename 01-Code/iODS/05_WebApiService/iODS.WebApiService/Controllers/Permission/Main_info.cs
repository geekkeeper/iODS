using System.Collections.Generic;

namespace iODS.WebApiService.Controllers
{
    /// <summary>
    /// 主信息类
    /// </summary>
    public class Main_info
    {
        // 一级菜单项
        public List<HeadItem> HeadMenu { get; set; }

        //所有菜单项
        public List<MenuItem> AllMenu { get; set; }

        //菜单树
        public Dictionary<string, List<RecursiveTreeModel>> RecursionMenuTree { get; set; }

        //用户信息
        public UserInfo GetUserInfo { get; set; }
    }

    /// <summary>
    /// 人员信息
    /// </summary>
    public class UserInfo
    {
        public string PersonCode { get; set; }          //人员Code
        public string PersonName { get; set; }          //人员姓名
        public string Account { get; set; }               //账号
        public string DeptCode { get; set; }             //部门Code
        public string DeptName { get; set; }            //部门名称
        public string CorpCode { get; set; }             //单位Code 
        public string CorpName { get; set; }            //单位名称
        public string WorkNum { get; set; }             //工号
        public string Pwd { get; set; }                    //密码
        public string RoleCode { get; set; }              //角色Code
        public string RoleName { get; set; }              //角色名
        public string DeptPowerCode { get; set; }      //部门权限
    }

    /// <summary>
    /// 一级菜单信息
    /// </summary>
    public class HeadItem
    {
        public string Code { get; set; }
        public string Title { get; set; }
        public string EnTitle { get; set; }
        public int Order { get; set; }
        public string IsHide { get; set; }
    }


    /// <summary>
    /// 菜单信息
    /// </summary>
    public class MenuItem
    {
        //菜单Code
        public string Code { get; set; }
        //菜单标题
        public string Title { get; set; }
        //英文标题
        public string EnTitle { get; set; }
        //数据权限
        public string DataPower { get; set; }
        //自定义权限
        public string CustomPower { get; set; }
        //页面按钮显示无
        public List<string> PageButtonConfigIDHidden { get; set; }
        //页面查询按钮显示无
        public List<string> PageQueryConfigIDHidden { get; set; }
        //页面grid列表显示无
        public List<string> PageGridConfigIDHidden { get; set; }
    }


    /// <summary>
    /// 菜单树
    /// </summary>
    public class RecursiveTreeModel
    {
        public string Code { get; set; }
        public string PCode { get; set; }
        public string Title { get; set; }
        public string EnTitle { get; set; }
        public string Link { get; set; }
        public string IsHide { get; set; }
    }

    /// <summary>
    /// 读取权限时候，传递用户code，和客户端IP
    /// </summary>
    public class SM_UserIP
    {
        public string personCode { get; set; }
        public string clientIp { get; set; }
    }

}
