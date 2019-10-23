using Microsoft.EntityFrameworkCore;

namespace DatabaseUpdate
{
    internal class Program
    {
        /// <summary>
        /// 是否存在数据库
        /// </summary>
        private static bool IsExistDB { set; get; }
        /// <summary>
        /// 是否与当前程序版本对应的数据可名称一致；
        /// 比如V1.0数据库名称叫AXXXX,V2.0-->BXXXXX……
        /// 当前版本数据库名称-->ZXXXXX
        /// </summary>
        private static bool IsConsistentDBName { set; get; }

        private static void Main()
        {
           var  context = new  TestDBContext();
           context.Database.Migrate();
            
            //TODO：判断数据库是否存在
            if (IsExistDB)
            {
                //TODO：存在-->判断当前数据库名称与最新数据库名称是否一致
                if (IsConsistentDBName)
                {
                    //TODO:一致-->更新表、表字段、视图、视图字段、存储过程等
                }
                else
                {
                    //TODO:不一致-->1.更新数据名称；2.更新表、表字段、视图、视图字段、存储过程等。
                }
            }
            else
            {
                //TODO:不存在-->创建最新版数据库
            }

        }

        /// <summary>
        /// 获取工程的数据库信息
        /// </summary>
        private static void GetProjectDBInfo()
        {
            IsExistDB = true;
            IsConsistentDBName = false;
        }
    }
}