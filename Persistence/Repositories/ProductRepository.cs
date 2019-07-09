using ECommerceStoreWebApi.Core.Domain;
using ECommerceStoreWebApi.Core.Repositories;

namespace ECommerceStoreWebApi.Persistence.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(ECommerce context)
            : base(context)
        {
        }

        public ECommerce ECommerce
        {
            get { return Context as ECommerce; }
        }
    }
}