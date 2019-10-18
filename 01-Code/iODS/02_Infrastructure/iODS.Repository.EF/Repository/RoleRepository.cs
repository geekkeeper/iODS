using iODS.Domain;
using iODS.Model;

namespace iODS.Repository.EF
{
    public class RoleRepository:BaseRepository<Role>,IRoleRepository
    {
        public RoleRepository(EFContext<Role> context) : base(context)
        {
        }
    }
}