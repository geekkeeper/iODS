using Hollysys.Common.Attribute;
using iODS.Domain;
using iODS.Model;

namespace iODS.Repository.SQLSugar
{
    [Repository]
    public class UserRepository:BaseRepository<User>,IUserRepository
    {
        
    }
}