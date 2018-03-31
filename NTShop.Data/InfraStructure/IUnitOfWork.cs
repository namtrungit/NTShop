namespace NTShop.Data.InfraStructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}