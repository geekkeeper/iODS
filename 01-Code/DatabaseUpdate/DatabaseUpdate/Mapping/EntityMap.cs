using DatabaseUpdate.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DatabaseUpdate.Mapping
{
    public static class EntityMap
    {
        /// <summary>
        /// 不映射的类型：未启用的表
        /// </summary>
        /// <param name="modelBuilder"></param>
        public static void NotMappedType(this ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<TestNotMapped>(); //不映射的类，在数据不创建对应的表
        }

        /// <summary>
        /// 部门表映射
        /// </summary>
        /// <param name="modelBuilder"></param>
        public static void DepartmentCreating(this ModelBuilder modelBuilder)
        {
            EntityTypeBuilder<Department> entity = modelBuilder.Entity<Department>().ToTable(nameof(Department));
            entity.HasKey(d => d.Id)                                        //设置主键
                  .HasName("PK_DepartmentID");                              //主键名称
            entity.Property(d => d.Id)                                      //--部门ID--
                  .HasColumnName(nameof(Department.Id))                     //字段名称
                  .HasColumnType("int")                                     //字段类型
                  .HasDefaultValueSql("NEXT VALUE FOR shared.DepartmentId") //设置自增
                  .IsRequired();                                            //不能为空
            entity.Property(d => d.DepartmentName)                          //--部门名称--
                  .HasColumnName(nameof(Department.DepartmentName))         //字段名称
                  .HasColumnType("varchar(20)")                             //字段类型
                  .IsRequired();                                            //不能为空
            entity.Property(d => d.Branch)                                  //-是否是公司-
                  .HasColumnName(nameof(Department.Branch))                 //字段名称
                  .IsRequired();                                            //不能为Null
            entity.Property(d => d.SuperiorId)                              //--上级部门--
                  .HasColumnName(nameof(Department.SuperiorId));            //字段名称
            entity.Property(d => d.Leader)                                  //--部门领导--
                  .HasColumnName(nameof(Department.Leader));                //字段名称
            entity.Property(d => d.CreatedTime)                             //--创建时间--
                  .HasColumnName(nameof(Department.CreatedTime))            //字段名称
                  .IsRequired()                                             //不能为Null
                  .ValueGeneratedOnAdd();                                   //添加时生成
            entity.Property(d => d.CreatedBy)                               //---创建人---
                  .HasColumnName(nameof(Department.CreatedBy))              //字段名称
                  .IsRequired();                                            //不能为Null
            entity.Property(d => d.UpdatedTime)                             //--更新时间--
                  .HasColumnName(nameof(Department.UpdatedTime));           //字段名称
            entity.Property(d => d.UpdatedBy)                               //---更新人---
                  .HasColumnName(nameof(Department.UpdatedBy))              //字段名称
                  .ValueGeneratedOnUpdate();                                //更新时生产
            entity.Property(d => d.Remark)                                  //--备注信息--
                  .HasColumnName(nameof(Department.Remark));                //字段名称
            entity.Ignore(d => d.Reserved);                                 //忽略字段：不创建此字段
        }

        /// <summary>
        /// 部门用户关系表映射
        /// </summary>
        /// <param name="modelBuilder"></param>
        public static void DepartmentUserCreating(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DepartmentUser>();
        }

        /// <summary>
        /// 工程表映射
        /// </summary>
        /// <param name="modelBuilder"></param>
        public static void ProjectCreating(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>();
        }

        /// <summary>
        /// 资源表映射
        /// </summary>
        /// <param name="modelBuilder"></param>
        public static void ResourceCreating(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Resource>();
        }

        /// <summary>
        /// 角色表映射
        /// </summary>
        /// <param name="modelBuilder"></param>
        public static void RoleCreating(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>();
        }

        /// <summary>
        /// 角色资源关系表映射
        /// </summary>
        /// <param name="modelBuilder"></param>
        public static void RoleResourceCreating(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RoleResource>();
        }

        /// <summary>
        /// 用户表映射
        /// </summary>
        /// <param name="modelBuilder"></param>
        public static void UserCreating(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>();
        }

        /// <summary>
        /// 用户角色关系表映射
        /// </summary>
        /// <param name="modelBuilder"></param>
        public static void UserRoleCreating(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserRole>();
        }
    }
}