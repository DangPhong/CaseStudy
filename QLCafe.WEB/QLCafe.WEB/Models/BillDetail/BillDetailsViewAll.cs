using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLCafe.WEB.Models.BillDetail
{
    public class BillDetailsViewAll
    {
        public int ID { get; set; }
        public int BillsDetailID { get; set; }
        public int TableID { get; set; }
        public DateTime DateTimeCheckIn { get; set; }
        public DateTime? DateTimeCheckOut { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
        public decimal SumTotal { get; set; }
        public string StrStatus { get; set; }
    }
}
