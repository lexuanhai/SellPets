using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace Domain
{
    [Table("siders")]
    public class Siders : BaseEntity<int>
    {
        [Column(TypeName = "varchar(500)")]
        public string? Image { get; set; }     
        public int? Status { get; set; }
    }
}
