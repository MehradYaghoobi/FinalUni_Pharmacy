using Microsoft.Extensions.Configuration;
using RestSharp;
using RestSharp.Serializers.Json;

namespace _0_Framework.Application.PaymentGateway
{
    public class PaymentFactory : IPaymentFactory
    {
        private readonly IConfiguration _configuration;

        public string Prefix { get; set; }
        private string MerchantId { get; }

        public PaymentFactory(IConfiguration configuration)
        {
            _configuration = configuration;
            Prefix = _configuration.GetSection("payment")["method"];
            MerchantId = _configuration.GetSection("payment")["merchant"];
        }

        public PaymentResponse CreatePaymentRequest(string amount, string mobile, string email, string description, long orderId)
        {
            throw new System.NotImplementedException();
        }

        public VerificationResponse CreateVerificationRequest(string authority, string price)
        {
            throw new System.NotImplementedException();
        }
    }
}
