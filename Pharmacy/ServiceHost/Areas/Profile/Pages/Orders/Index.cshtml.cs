using System.Collections.Generic;
using _0_Framework.Application;
using AccountManagement.Application.Contracts.Account;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ServiceHost.Areas.Administration.Pages.Accounts.Role;
using ShopManagement.Application.Contracts.Order;

namespace ServiceHost.Areas.Profile.Pages.Orders
{
    public class IndexModel : PageModel
    {
        public OrderSearchModel SearchModel;
        public SelectList Accounts;
        public List<OrderViewModel> Orders;
        public long UserId;

        private readonly IOrderApplication _orderApplication;
        private readonly IAccountApplication _accountApplication;
        private readonly IAuthHelper _authHelper;

        public IndexModel(IOrderApplication orderApplication, IAccountApplication accountApplication, IAuthHelper authHelper)
        {
            _orderApplication = orderApplication;
            _accountApplication = accountApplication;
            _authHelper = authHelper;
        }

        public void OnGet(OrderSearchModel searchModel)
        {
            Accounts = new SelectList(_accountApplication.GetAccounts(), "Id", "Fullname");
            Orders = _orderApplication.Search(searchModel);
            UserId = _authHelper.CurrentAccountId();
        }

        public IActionResult OnGetItems(long id)
        {
            var items = _orderApplication.GetItems(id);
            return Partial("Items", items);
        }
    }
}