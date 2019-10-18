using System.Collections.Generic;
using System.Linq;

namespace Hollysys.Common
{
    /// <summary>
    /// 泛型递归求树形结构
    /// </summary>
    public static class RecursionHelper
    {
        public static void LoopToAppendChildren(IEnumerable<PermissionTree> all, PermissionTree curItem, int pid, bool needBtn)
        {
            IEnumerable<PermissionTree> permissionTrees = all.ToList();
            List<PermissionTree> subItems = permissionTrees.Where(ee => ee.Pid == curItem.value).ToList();

            List<PermissionTree> btnItems = subItems.Where(ss => ss.isBtn).ToList();
            if (subItems.Count > 0)
            {
                curItem.btns = new List<PermissionTree>();
                curItem.btns.AddRange(btnItems);
            }
            else
            {
                curItem.btns = null;
            }

            if (!needBtn)
            {
                subItems = subItems.Where(ss => ss.isBtn == false).ToList();
            }
            if (subItems.Count > 0)
            {
                curItem.children = new List<PermissionTree>();
                curItem.children.AddRange(subItems);
            }
            else
            {
                curItem.children = null;
            }

            if (curItem.isBtn)
            {
                //curItem.label += "按钮";
            }

            foreach (PermissionTree subItem in subItems)
            {
                if (subItem.value == pid && pid > 0)
                {
                    //subItem.disabled = true;//禁用当前节点
                }
                LoopToAppendChildren(permissionTrees, subItem, pid, needBtn);
            }
        }

        public static void LoopNaviBarAppendChildren(List<NavigationBar> all, NavigationBar curItem)
        {
            List<NavigationBar> subItems = all.Where(ee => ee.Pid == curItem.Id).ToList();

            if (subItems.Count > 0)
            {
                curItem.Children = new List<NavigationBar>();
                curItem.Children.AddRange(subItems);
            }
            else
            {
                curItem.Children = null;
            }

            foreach (NavigationBar subItem in subItems)
            {
                LoopNaviBarAppendChildren(all, subItem);
            }
        }

        public static void LoopToAppendChildrenT<T>(List<T> all, T curItem, string parentIdName = "Pid", string idName = "value", string childrenName = "Children")
        {
            List<T> subItems = all.Where(ee => ee.GetType().GetProperty(parentIdName)?.GetValue(ee, null).ToString() == curItem.GetType().GetProperty(idName)?.GetValue(curItem, null).ToString()).ToList();

            if (subItems.Count > 0)
            {
                curItem.GetType().GetField(childrenName).SetValue(curItem, subItems);
            }

            foreach (T subItem in subItems)
            {
                LoopToAppendChildrenT(all, subItem);
            }
        }
    }

    public class PermissionTree
    {
        public int value { get; set; }
        public int Pid { get; set; }
        public string label { get; set; }
        public int order { get; set; }
        public bool isBtn { get; set; }
        public bool disabled { get; set; }
        public List<PermissionTree> children { get; set; }
        public List<PermissionTree> btns { get; set; }
    }

    public class NavigationBar
    {
        public int Id { get; set; }
        public int Pid { get; set; }
        public int Order { get; set; }
        public string Name { get; set; }
        public bool IsHide { get; set; }
        public string Path { get; set; }
        public string IconCls { get; set; }
        public NavigationBarMeta Meta { get; set; }
        public List<NavigationBar> Children { get; set; }
    }

    public class NavigationBarMeta
    {
        public string Title { get; set; }
        public bool RequireAuth { get; set; } = true;
        public bool NoTabPage { get; set; }
    }
}