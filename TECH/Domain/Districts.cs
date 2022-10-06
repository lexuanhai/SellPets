using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace Domain
{
    [Table("Districts")]
    public class Districts : BaseEntity<int>
    {
        public int? City_id { get; set; }
        [ForeignKey("City_id")]
        public City? City { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string? Name { get; set; }
    }
}
