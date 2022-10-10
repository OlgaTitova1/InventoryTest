using Inventory.DAL.Interfaces;
using Inventory.DAL.Context;

namespace Inventory.DAL.Repositories
{
    public class ProductSupplierInfoRepository : BaseRepository<ProductSupplierInfo>, IProductSupplierInfoRepository
    {
        public ProductSupplierInfoRepository(InventoriesEntities context)
           : base(context)
        {
        }
    }
}
