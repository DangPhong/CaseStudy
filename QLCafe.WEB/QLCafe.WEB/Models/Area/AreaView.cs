using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QLCafe.WEB.Models
{
    public class AreaView
    {
        public int ID { get; set; }
        [Display(Name = "Tên khu vực")]
        public string Name { get; set; }
    }
}
