using System;
using System.Collections.Generic;
using System.Text;

namespace QLCafe.Domain.Request
{
    public class AccountUpdate
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
    }
}
