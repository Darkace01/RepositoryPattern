using ECommerceStoreWebApi.Core.Repositories;
using System;

namespace ECommerceStoreWebApi.Core
{
    interface IUnitOfWork : IDisposable
    {
        IProductRepository Products { get; }
        int Complete();
    }
}
