using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLCafe.WEB.Models.BillDetail
{
    public class BillDetails
    {
        public int ID { get; set; }
        public int BillID { get; set; }
        public int ProductID { get; set; }
        public int Number { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
    }
}
