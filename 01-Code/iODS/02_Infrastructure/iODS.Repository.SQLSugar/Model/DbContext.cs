using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hollysys.Common;
using SqlSugar;
using StackExchange.Profiling;

namespace iODS.Repository.SQLSugar
{
    /// <summary>
    ///     数据库上下文
    /// </summary>
    public class DbContext
    {
        //private readonly ILogger _loggerHelper = new LoggerHelper();

        /// <summary>
        ///     功能描述:构造函数
        /// </summary>
        /// <param name="isAutoCloseConnection">是否自动关闭连接</param>
        private DbContext(bool isAutoCloseConnection = true)
        {
            if (string.IsNullOrEmpty(ConnectionString))
            {
                throw new ArgumentNullException("数据库连接字符串为空");
            }

            this.SugarClient = new SqlSugarClient(new ConnectionConfig
            {
                    ConnectionString          = ConnectionString,
                    DbType                    = DbType,
                    IsAutoCloseConnection     = isAutoCloseConnection,
                    IsShardSameThread         = false,
                    ConfigureExternalServices = new ConfigureExternalServices(),
                    MoreSettings = new ConnMoreSettings
                    {
                            IsAutoRemoveDataCache = true
                    }
            });

            this.SugarClient.MappingTables.Add("","");
            this.SugarClient.Aop.OnLogExecuting = (sql, pars) => //SQL执行中事件
            {
                Parallel.For(0, 1, e =>
                {
                    MiniProfiler.Current.CustomTiming("SQL：", GetParas(pars) + "【SQL语句】：" + sql);
                    LogLock.OutSql2Log("SqlLog", new[] {GetParas(pars), "【SQL语句】：" + sql});
                });
            };
        }

        /// <summary>
        ///     连接字符串
        /// </summary>
        public static string ConnectionString { get; set; }

        /// <summary>
        ///     数据库类型
        /// </summary>
        public static DbType DbType { get; set; }

        /// <summary>
        ///     数据连接对象
        /// </summary>
        public SqlSugarClient SugarClient { get; }

        /// <summary>
        ///     数据库上下文实例（自动关闭连接）
        /// </summary>
        public static DbContext Context => new DbContext();

        private static string GetParas(IEnumerable<SugarParameter> parameters)
        {
            return parameters.Aggregate("【SQL参数】：",
                    (current, param) => current + $"{param.ParameterName}:{param.Value}\n");
        }

        #region 实例方法

        /// <summary>
        ///     功能描述:获取数据库处理对象
        /// </summary>
        /// <returns>返回值</returns>
        public SimpleClient<T> GetEntityDb<T>() where T : class, new()
        {
            return new SimpleClient<T>(this.SugarClient);
        }

        /// <summary>
        ///     功能描述:获取数据库处理对象
        /// </summary>
        /// <param name="sugarClient">db</param>
        /// <returns>返回值</returns>
        public static SimpleClient<T> GetEntityDb<T>(SqlSugarClient sugarClient) where T : class, new()
        {
            return new SimpleClient<T>(sugarClient);
        }

        #region 根据数据库表生产实体类

        /// <summary>
        ///     功能描述:根据数据库表生产实体类
        /// </summary>
        /// <param name="path">实体类存放路径</param>
        /// <param name="nameSpace">命名空间</param>
        public void CreateClassFileByDbTable(string path, string nameSpace = "iODS.IRepository.Entity")
        {
            this.CreateClassFileByDbTable(path, nameSpace, null);
        }

        /// <summary>
        ///     功能描述:根据数据库表生产实体类
        /// </summary>
        /// <param name="path">实体类存放路径</param>
        /// <param name="nameSpace">命名空间</param>
        /// <param name="tableNames">生产指定的表</param>
        public void CreateClassFileByDbTable(
                string path,
                string nameSpace,
                string[] tableNames)
        {
            this.CreateClassFileByDbTable(path, nameSpace, tableNames, string.Empty);
        }

        /// <summary>
        ///     功能描述:根据数据库表生产实体类
        /// </summary>
        /// <param name="path">实体类存放路径</param>
        /// <param name="nameSpace">命名空间</param>
        /// <param name="tableNames">生产指定的表</param>
        /// <param name="strInterface">实现接口</param>
        /// <param name="isSerializable">是否实现序列化</param>
        public void CreateClassFileByDbTable(
                string path,
                string nameSpace,
                string[] tableNames,
                string strInterface,
                bool isSerializable = false)
        {
            if (tableNames != null && tableNames.Length > 0)
            {
                this.SugarClient.DbFirst.Where(tableNames).IsCreateDefaultValue().IsCreateAttribute()
                    .SettingClassTemplate(p =>
                    {
                        if (p == null)
                        {
                            throw new ArgumentNullException(nameof(p));
                        }

                        return @"
{using}

namespace {Namespace}
{
    {ClassDescription}{SugarTable}" + (isSerializable ? "[Serializable]" : "") + @"
    public partial class {ClassName}" + (string.IsNullOrEmpty(strInterface) ? "" : " : " + strInterface) + @"
    {
        public {ClassName}()
        {
{Constructor}
        }
{PropertyName}
    }
}
";
                    })
                    .SettingPropertyTemplate(p => @"
            {SugarColumn}
            public {PropertyType} {PropertyName}
            {
                get
                {
                    return _{PropertyName};
                }
                set
                {
                    if(_{PropertyName}!=value)
                    {
                        base.SetValueCall(" + "\"{PropertyName}\",_{PropertyName}" + @");
                    }
                    _{PropertyName}=value;
                }
            }")
                    .SettingPropertyDescriptionTemplate(p =>
                            "          private {PropertyType} _{PropertyName};\r\n" + p)
                    .SettingConstructorTemplate(p =>
                    {
                        if (p == null)
                        {
                            throw new ArgumentNullException(nameof(p));
                        }

                        return "              this._{PropertyName} ={DefaultValue};";
                    })
                    .CreateClassFile(path, nameSpace);
            }
            else
            {
                this.SugarClient.DbFirst.IsCreateAttribute().IsCreateDefaultValue()
                    .SettingClassTemplate(p => @"
{using}

namespace {Namespace}
{
    {ClassDescription}{SugarTable}" + (isSerializable ? "[Serializable]" : "") + @"
    public partial class {ClassName}" + (string.IsNullOrEmpty(strInterface) ? "" : " : " + strInterface) + @"
    {
        public {ClassName}()
        {
{Constructor}
        }
{PropertyName}
    }
}
")
                    .SettingPropertyTemplate(p => @"
            {SugarColumn}
            public {PropertyType} {PropertyName}
            {
                get
                {
                    return _{PropertyName};
                }
                set
                {
                    if(_{PropertyName}!=value)
                    {
                        base.SetValueCall(" + "\"{PropertyName}\",_{PropertyName}" + @");
                    }
                    _{PropertyName}=value;
                }
            }")
                    .SettingPropertyDescriptionTemplate(p =>
                            "          private {PropertyType} _{PropertyName};\r\n" + p)
                    .SettingConstructorTemplate(p => "              this._{PropertyName} ={DefaultValue};")
                    .CreateClassFile(path, nameSpace);
            }
        }

        #endregion

        #region 根据实体类生成数据库表

        /// <summary>
        ///     功能描述:根据实体类生成数据库表
        /// </summary>
        /// <param name="isBackupTable">是否备份表</param>
        /// <param name="entities">指定的实体</param>
        public void CreateTableByEntity<T>(bool isBackupTable, params T[] entities) where T : class, new()
        {
            Type[] lstTypes = null;
            if (entities != null)
            {
                lstTypes = new Type[entities.Length];
                for (var i = 0; i < entities.Length; i++)
                {
                    lstTypes[i] = typeof(T);
                }
            }

            this.CreateTableByEntity(isBackupTable, lstTypes);
        }

        /// <summary>
        ///     功能描述:根据实体类生成数据库表
        /// </summary>
        /// <param name="isBackupTable">是否备份表</param>
        /// <param name="entities">指定的实体</param>
        public void CreateTableByEntity(bool isBackupTable, params Type[] entities)
        {
            if (isBackupTable)
            {
                this.SugarClient.CodeFirst.BackupTable().InitTables(entities); //change entity backupTable            
            }
            else
            {
                this.SugarClient.CodeFirst.InitTables(entities);
            }
        }

        #endregion

        #endregion

        #region 静态方法

        /// <summary>
        ///     功能描述:获得一个DbContext
        /// </summary>
        /// <param name="isAutoCloseConnection">是否自动关闭连接（如果为false，则使用接受时需要手动关闭Db）</param>
        /// <returns>返回值</returns>
        public static DbContext GetDbContext(bool isAutoCloseConnection = true)
        {
            return new DbContext(isAutoCloseConnection);
        }

        /// <summary>
        ///     功能描述:设置初始化参数
        /// </summary>
        /// <param name="connectionString">连接字符串</param>
        /// <param name="dbType">数据库类型</param>
        public static void Init(string connectionString, DbType dbType = DbType.SqlServer)
        {
            ConnectionString = connectionString;
            DbType           = dbType;
        }

        /// <summary>
        ///     功能描述:创建一个链接配置
        /// </summary>
        /// <param name="isAutoCloseConnection">是否自动关闭连接</param>
        /// <param name="isShardSameThread">是否夸类事务</param>
        /// <returns>ConnectionConfig</returns>
        public static ConnectionConfig GetConnectionConfig(bool isAutoCloseConnection = true,
                                                           bool isShardSameThread = false)
        {
            var config = new ConnectionConfig
            {
                    ConnectionString          = ConnectionString,
                    DbType                    = DbType,
                    IsAutoCloseConnection     = isAutoCloseConnection,
                    ConfigureExternalServices = new ConfigureExternalServices(),
                    IsShardSameThread         = isShardSameThread
            };
            return config;
        }

        /// <summary>
        ///     功能描述:获取一个自定义的DB
        /// </summary>
        /// <param name="config">config</param>
        /// <returns>返回值</returns>
        public static SqlSugarClient GetCustomDb(ConnectionConfig config)
        {
            return new SqlSugarClient(config);
        }

        /// <summary>
        ///     功能描述:获取一个自定义的数据库处理对象
        /// </summary>
        /// <param name="sugarClient">sugarClient</param>
        /// <returns>返回值</returns>
        public static SimpleClient<T> GetCustomEntityDb<T>(SqlSugarClient sugarClient) where T : class, new()
        {
            return new SimpleClient<T>(sugarClient);
        }

        /// <summary>
        ///     功能描述:获取一个自定义的数据库处理对象
        /// </summary>
        /// <param name="config">config</param>
        /// <returns>返回值</returns>
        public static SimpleClient<T> GetCustomEntityDb<T>(ConnectionConfig config) where T : class, new()
        {
            var sugarClient = GetCustomDb(config);
            return GetCustomEntityDb<T>(sugarClient);
        }

        #endregion
    }
}