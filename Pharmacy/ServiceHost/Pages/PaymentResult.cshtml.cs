using _0_Framework.Application;
using _01_PharmacyQuery.Contracts.Product;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Nancy.Json;
using ShopManagement.Application.Contracts.Order;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ServiceHost.Pages
{
    public class PaymentResultModel : PageModel
    {
        public List<CartItem> CartItems;
        public const string CookieName = "cart-items";
        private readonly IProductQuery _productQuery;
        public PaymentResult Result;

        public PaymentResultModel(IProductQuery productQuery)
        {
            CartItems = new List<CartItem>();
            _productQuery = productQuery;
        }
        

        public void OnGet(PaymentResult result)
        {
            Result = result;
        }
    }
}