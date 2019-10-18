using iODS.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace iODS.Repository.EF
{
    public class DepartmentMap:IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(c => c.Id).HasColumnName("ID");
//            builder.Property(c => c.DeptName).HasColumnName("DeptName").HasColumnType("varchar(50)").HasMaxLength(50)
//                   .IsRequired();

        }
    }
}