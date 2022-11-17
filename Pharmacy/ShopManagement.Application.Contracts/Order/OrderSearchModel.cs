using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Application.Contracts.Order
{
    public class OrderSearchModel
    {
        public long AccountId { get; set; }
        public bool IsCanceled { get; set; }
    }
}
