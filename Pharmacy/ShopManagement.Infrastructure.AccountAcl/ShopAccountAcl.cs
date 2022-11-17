using AccountManagement.Application.Contracts.Account;
using ShopManagement.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Infrastructure.AccountAcl
{
    public class ShopAccountAcl : IShopAccountAcl
    {
        private readonly IAccountApplication _accountApplication;

        public ShopAccountAcl(IAccountApplication accountApplication)
        {
            _accountApplication = accountApplication;
        }

        public (string name, string mobile) GetAccountBy(long id)
        {
            var account = _accountApplication.GetAccountBy(id);
            return (account.Fullname, account.Mobile);
        }
    }
}
