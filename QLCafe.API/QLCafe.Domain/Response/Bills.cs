using System;
using System.Collections.Generic;
using System.Text;

namespace QLCafe.Domain.Response
{
    public class Bills
    {
        public int ID { get; set; }
        public int TableID { get; set; }
        public DateTime DateTimeCheckIn { get; set; }
        public DateTime? DateTimeCheckOut { get; set; }
        public string StrStatus { get; set; }
        public bool HasBillDetails { get; set; }
    }
}
