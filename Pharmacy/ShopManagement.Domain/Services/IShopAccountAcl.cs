using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Domain.Services
{
    public interface IShopAccountAcl
    {
        (string name, string mobile) GetAccountBy(long id);
    }
}
