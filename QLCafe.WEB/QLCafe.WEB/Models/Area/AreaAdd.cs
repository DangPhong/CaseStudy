using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace QLCafe.WEB.Models
{
    public class AreaAdd
    {
        [Display(Name="Tên khu vực")]
        public string Name { get; set; }
    }
}
