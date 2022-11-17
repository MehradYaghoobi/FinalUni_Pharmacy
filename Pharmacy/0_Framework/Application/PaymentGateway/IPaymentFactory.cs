using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Framework.Application.PaymentGateway
{
    public interface IPaymentFactory
    {
        string Prefix { get; set; }

        PaymentResponse CreatePaymentRequest(string amount, string mobile, string email, string description, long orderId);

        VerificationResponse CreateVerificationRequest(string authority, string price);
    }
}
