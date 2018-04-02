using NTShop.Data.InfraStructure;
using NTShop.Model.Model;

namespace NTShop.Data.Respositories
{
    public interface IFooterRepository : IRepository<Footer>
    {
    }

    public class FooterRepository : RepositoryBase<Footer>
    {
        public FooterRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}