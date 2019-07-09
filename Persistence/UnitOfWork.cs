using ECommerceStoreWebApi.Core;
using ECommerceStoreWebApi.Core.Domain;
using ECommerceStoreWebApi.Core.Repositories;
using ECommerceStoreWebApi.Persistence.Repositories;

namespace ECommerceStoreWebApi.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ECommerce _context;

        public UnitOfWork(ECommerce context)
        {
            _context = context;
            Products = new ProductRepository(_context);
        }

        public IProductRepository Products { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        private ProductRepository productRepository;
        public ProductRepository ProductRepository
        {
            get
            {
                if (productRepository == null)
                    productRepository = new ProductRepository(_context);
                return productRepository;
            }
        }
    }
}