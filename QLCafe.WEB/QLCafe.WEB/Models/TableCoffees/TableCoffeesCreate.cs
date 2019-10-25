using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QLCafe.WEB.Models.TableCoffees
{
    public class TableCoffeesCreate
    {
        [Display(Name ="Khu Vực")]
        [Required]
        public int AreaID { get; set; }
        [Display(Name = "Tên Bàn")]
        [Required]
        public string Name { get; set; }
    }
}
