using iODS.Domain;
using iODS.Model;

namespace iODS.Repository.EF
{
    public class DepartmentRepository:BaseRepository<Department>,IDepartmentRepository
    {
        public DepartmentRepository(EFContext<Department> context) : base(context)
        {
        }
    }
}