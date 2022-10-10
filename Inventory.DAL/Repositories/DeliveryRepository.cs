using Inventory.DAL.Interfaces;
using Inventory.DAL.Context;

namespace Inventory.DAL.Repositories
{
    public class DeliveryRepository : BaseRepository<Delivery>, IDeliveryRepository
    {
        public DeliveryRepository(InventoriesEntities context)
           : base(context)
        {
        }
    }
}
