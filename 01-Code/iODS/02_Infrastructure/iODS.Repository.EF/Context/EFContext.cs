using System;
using Hollysys.Common;
using iODS.Model;
using Microsoft.EntityFrameworkCore;

namespace iODS.Repository.EF
{
    public class EFContext<T>:DbContext where T : BaseEntity, new()
    {
        protected DbSet<T> DbSet { get; set; }
        
//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.ApplyConfiguration(new DepartmentMap());
//            base.OnModelCreating(modelBuilder);
//        }

        /// <summary>
        /// 重写数据库连接
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            switch (DatabaseConfig.DataBaseType)
            {
                case DataBaseType.MySql:
                    optionsBuilder.UseMySql(DatabaseConfig.ConnectionString);
                    break;
                case DataBaseType.SqlServer:
                    optionsBuilder.UseSqlServer(DatabaseConfig.ConnectionString);
                    break;
                case DataBaseType.Sqlite:
                    optionsBuilder.UseSqlite(DatabaseConfig.ConnectionString);
                    break;
                case DataBaseType.Oracle:
                    optionsBuilder.UseOracle(DatabaseConfig.ConnectionString);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            
            base.OnConfiguring(optionsBuilder);
        }
    }
}