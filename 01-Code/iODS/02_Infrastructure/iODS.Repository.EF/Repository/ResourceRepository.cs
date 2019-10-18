using iODS.Domain;
using iODS.Model;

namespace iODS.Repository.EF
{
    public class ResourceRepository:BaseRepository<Resource>,IResourceRepository
    {
        public ResourceRepository(EFContext<Resource> context) : base(context)
        {
        }
    }
}