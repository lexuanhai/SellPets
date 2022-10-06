using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace Domain
{
    [Table("Cities")]
    public class City : BaseEntity<int>
    {
        [Column(TypeName = "nvarchar(500)")]
        public string? Name { get; set; }
    }
}
