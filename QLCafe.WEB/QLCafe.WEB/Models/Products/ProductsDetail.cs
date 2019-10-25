using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace QLCafe.WEB.Models.Products
{
    public class ProductsDetail
    {
        public int ID { get; set; }
        [Display(Name="Tên món")]
        public string Name { get; set; }
        [Display(Name = "Thể loại món")]
        public string TypeName { get; set; }
        [Display(Name = "Đơn vị")]
        public string UnitName { get; set; }
        [Display(Name = "Giá")]
        public decimal Price { get; set; }
    }
}
