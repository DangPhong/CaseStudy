using System;
using System.Collections.Generic;
using System.Text;

namespace QLCafe.Domain.Requets
{
    public class BillDetailsView
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
