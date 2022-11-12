using _0_Framework.Domain;
using InventoryManagement.Application.Contract.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Domain.InventoryAgg
{
    public interface IInventoryRepository : IRepository<long, Inventory>
    {
        EditInventory GetDetails(long id);
        Inventory GetBy(long productId);
        List<InventoryViewModel> Search(InventorySearchModel searchModel);
        List<InventoryOperationViewModel> GetOperationLog(long inventoryId);
    }
}
