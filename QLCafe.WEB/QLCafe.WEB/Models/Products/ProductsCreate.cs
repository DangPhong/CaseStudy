using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QLCafe.WEB.Models.Products
{
    public class ProductsCreate
    {
        [Display(Name = "Tên món")]
        [Required(ErrorMessage = "Bạn phải nhập tên món")]
        public string Name { get; set; }
        [Display(Name = "Thể loại món")]
        public int TypeID { get; set; }
        [Display(Name = "Đơn vị")]
        public int UnitID { get; set; }
        [Display(Name = "Giá")]
        [Required(ErrorMessage = "Bạn phải nhập giá")]
       // [StringLength(maximumLength: 25, MinimumLength = 10, ErrorMessage = "Length must be between 10 to 25")]
        public decimal Price { get; set; }
    }
}
