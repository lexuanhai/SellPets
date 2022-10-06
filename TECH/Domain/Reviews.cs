using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace Domain
{
    [Table("reviews")]
    // phải đăng ký
    public class Reviews : BaseEntity<int>
    {
        public int? OrderId { get; set; }
        [ForeignKey("order_id")]
        public Orders? Orders { get; set; }
        public int? ProductId { get; set; }
        [ForeignKey("product_id")]
        public Products? Products { get; set; }
        [Column(TypeName = "nvarchar(max)")]
        public int? Status { get; set; }
        public int? Star { get; set; }
    }
}
