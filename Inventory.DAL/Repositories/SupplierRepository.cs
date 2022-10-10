using Inventory.DAL.Context;
using Inventory.DAL.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.DAL.Repositories
{
    public class SupplierRepository : BaseRepository<Supplier>, ISupplierRepository
    {
        public SupplierRepository(InventoriesEntities context)
           : base(context)
        {
        }
    }
}
