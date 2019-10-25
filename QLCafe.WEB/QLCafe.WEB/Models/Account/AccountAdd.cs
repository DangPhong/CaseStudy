using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLCafe.Web.Models.Account
{
    public class AccountAdd
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
    }
}
