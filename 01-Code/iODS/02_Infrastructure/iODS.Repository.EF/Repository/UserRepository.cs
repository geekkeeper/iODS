using iODS.Domain;
using iODS.Model;

namespace iODS.Repository.EF
{
    public class UserRepository:BaseRepository<User>,IUserRepository
    {
        public UserRepository(EFContext<User> context) : base(context)
        {
        }
    }
}     