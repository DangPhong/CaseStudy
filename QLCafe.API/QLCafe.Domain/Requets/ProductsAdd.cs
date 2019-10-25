using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QLCafe.Domain.Requets
{
    public class ProductsAdd
    {
        [Required(ErrorMessage = "Bạn phải nhập tên món")]
        public int TypeID { get; set; }
        [Required(ErrorMessage = "Bạn phải nhập tên món")]
        public int UnitID { get; set; }
        [Display(Name = "Tên món")]
        [Required(ErrorMessage = "Bạn phải nhập tên món")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Bạn phải nhập giá")]
        [Display(Name = "Giá")]
        public decimal Price { get; set; }
    }
}
