using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Framework.Application
{
    public class PaymentResult
    {
        public bool IsSuccessful { get; set; }
        public string Message { get; set; }
        public string IssueTrackingNo { get; set; }

        public PaymentResult Succeeded(string message, string issueTrackingNo)
        {
            IsSuccessful = true;
            Message = message;
            IssueTrackingNo = issueTrackingNo;
            return this;
        }

        public PaymentResult Failed(string message)
        {
            Message = message;
            IsSuccessful = false;
            return this;
        }
    }
}
