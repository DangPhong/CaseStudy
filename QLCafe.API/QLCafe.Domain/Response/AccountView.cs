﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QLCafe.Domain.Response
{
    public class AccountView
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
    }
}
