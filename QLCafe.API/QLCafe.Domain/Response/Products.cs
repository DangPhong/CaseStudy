﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QLCafe.Domain.Response
{
    public class Products
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string TypeName { get; set; }
        public string UnitName { get; set; }
        public decimal Price { get; set; }
    }
}
