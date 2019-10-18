using System.Threading.Tasks;
using Hollysys.Common.Attribute;
using iODS.Domain;
using iODS.Model;

namespace iODS.Repository.SQLSugar
{
    [Repository]
    public class DepartmentRepository:BaseRepository<Department>,IDepartmentRepository
    {
        private object dbContext;

        protected DepartmentRepository(object dbContext)
        {
            this.dbContext = dbContext;
        }

        public override Task<bool> Delete(object id)
        {
            
            return base.Delete(id);
        }
    }
}