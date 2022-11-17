using ShopManagement.Domain.OrderAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Domain.Services
{
    public interface IShopInventoryAcl
    {
        bool ReduceFromInventory(List<OrderItem> items);
    }
}
