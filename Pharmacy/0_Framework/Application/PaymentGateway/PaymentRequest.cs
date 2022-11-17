using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Framework.Application.PaymentGateway
{
    public class PaymentRequest
    {
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string CallbackURL { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
        public string MerchantID { get; set; }
    }
}
