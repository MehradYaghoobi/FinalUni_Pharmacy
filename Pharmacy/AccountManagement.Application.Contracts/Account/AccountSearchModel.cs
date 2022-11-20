using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.Application.Contracts.Account
{
    public class AccountSearchModel
    {
        public string Fullname { get; set; }
        public string Username { get; set; }
        public string Mobile { get; set; }
        public long RoleId { get; set; }
        public string Address { get; set; }
        public string CodePosti { get; set; }
    }
}
