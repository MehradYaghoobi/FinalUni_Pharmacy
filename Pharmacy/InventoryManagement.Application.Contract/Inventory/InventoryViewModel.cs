using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Application.Contract.Inventory
{
    public class InventoryViewModel
    {
        public long Id { get; set; }
        public string Product { get; set; }
        public long ProductId { get; set; }
        public double UnitPrice { get; set; }
        public bool InStock { get; set; }
        public long CurrentCount { get; set; }
        public string CreationDate { get; set; }
    }
}
