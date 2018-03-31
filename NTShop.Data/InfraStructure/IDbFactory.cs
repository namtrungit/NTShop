using System;

namespace NTShop.Data.InfraStructure
{
    public interface IDbFactory : IDisposable
    {
        NTShopDbContext Init();
    }
}