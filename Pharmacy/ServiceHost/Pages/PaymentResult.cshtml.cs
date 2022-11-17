using _0_Framework.Application;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class PaymentResultModel : PageModel
    {
        public PaymentResult Result;

        public void OnGet(PaymentResult result)
        {
            Result = result;
        }
    }
}