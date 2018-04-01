using NTShop.Data.InfraStructure;
using NTShop.Model.Model;

namespace NTShop.Data.Respositories
{
    public interface IVisistorStaticRepository
    {
    }

    public class VisistorStaticRepository : RepositoryBase<VisistorStatic>, IVisistorStaticRepository
    {
        public VisistorStaticRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}