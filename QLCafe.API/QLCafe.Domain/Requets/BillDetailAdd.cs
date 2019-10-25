using System;
using System.Collections.Generic;
using System.Text;

namespace QLCafe.Domain.Requets
{
  public   class BillDetailAdd
    {
        public int BillID { get; set; }
        public int ProductID { get; set; }
        public int Number { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
    }
}
