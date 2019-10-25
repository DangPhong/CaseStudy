using System;
using System.Collections.Generic;
using System.Text;

namespace QLCafe.Domain.Requets
{
    public class TableCoffeesUpdate
    {
        public int Id { get; set; }
        public int AreaID { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
    }
}
