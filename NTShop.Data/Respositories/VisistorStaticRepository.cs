using NTShop.Data.InfraStructure;
using NTShop.Model.Model;

namespace NTShop.Data.Respositories
{
    public interface IVisistorStaticRepository : IRepository<VisistorStatic>
    {
    }

    public class VisistorStaticRepository : RepositoryBase<VisistorStatic>, IVisistorStaticRepository
    {
        public VisistorStaticRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}