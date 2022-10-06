using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace Domain
{
    [Table("OrderDetails")]
    public class OrdersDetails : BaseEntity<int>
    {
        public int? OrderId { get; set; }
        [ForeignKey("OrderId")]
        public Orders? Orders { get; set; }
        public int? ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Products? Products { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Price { get; set; }
        public int? Quantity { get; set; }
    }
}
