using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace Domain
{
    [Table("Orders")]
    public class Orders : BaseEntity<int>
    {
        [Column(TypeName = "nvarchar(250)")]
        public string? Code { get; set; }
        public int? CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public Customers? Customers { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        public string? Note { get; set; }
        public int? Review { get; set; }
        public int Payment { get; set; }
        public int? Status { get; set; }
        public int? Total { get; set; }
        public int? Fee_ship { get; set; }
    }
}
