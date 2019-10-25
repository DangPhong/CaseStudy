using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QLCafe.WEB.Models.Bills
{
    public class Bills
    {
        [Display(Name = "Hóa Đơn ID:")]
        public int ID { get; set; }
        [Display(Name = "ID Bàn:")]
        public int TableID { get; set; }
        [Display(Name = "TG Tạo:")]
        public DateTime DateTimeCheckIn { get; set; }
        [Display(Name = "TG Thanh Toán:")]
        public DateTime? DateTimeCheckOut { get; set; }
        [Display(Name = "Trạng Thái:")]
        public int Status { get; set; }
        [Display(Name ="Trạng Thái:")]
        public string StrStatus { get; set; }
        public bool HasBillDetails { get; set; }
    }
}
