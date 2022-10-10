using Inventory.DAL.Interfaces;
using Inventory.DAL.Context;

namespace Inventory.DAL.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(InventoriesEntities context)
           : base(context)
        {
        }
    }
}
