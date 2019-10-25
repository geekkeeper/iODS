using DatabaseUpdate.Mapping;
using Microsoft.EntityFrameworkCore;

namespace DatabaseUpdate
{
    public class TestDBContext:DbContext
    {
//        public DbSet<Department> Departments { set; get; }
//        public DbSet<Resource> Resources { set; get; }
//        public DbSet<Role> Roles { set; get; }
//        public DbSet<User> Users { set; get; }
//        public DbSet<UserRole> UserRoles { set; get; }
//        public DbSet<RoleResource> RoleResources { set; get; }
        //关于数据库配置
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=192.168.2.100;Initial Catalog=TestDB; User Id=sa;Password=wx123456");
        }

        /// <summary>
        /// 关于模型创建
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasSequence<int>("DepartmentId", schema: "shared")
                        .StartsAt(100000001)
                        .IncrementsBy(1);
            modelBuilder.DepartmentCreating();
//            modelBuilder.DepartmentUserCreating();
//            modelBuilder.ProjectCreating();
//            modelBuilder.ResourceCreating();
//            modelBuilder.RoleCreating();
//            modelBuilder.RoleResourceCreating();
//            modelBuilder.UserCreating();
//            modelBuilder.UserRoleCreating();
        }
    }
}