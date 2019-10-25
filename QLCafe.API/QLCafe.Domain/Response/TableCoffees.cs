using System;
using System.Collections.Generic;
using System.Text;

namespace QLCafe.Domain.Response
{
    public class TableCoffees
    {
        public int ID { get; set; }
        public int AreaID { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
    }
}
