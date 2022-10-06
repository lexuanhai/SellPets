using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    [Table("Categories")]
    public class Category: BaseEntity<int>
    {
        [Column(TypeName = "nvarchar(250)")]
        public string? Name { get; set; }
        [Column(TypeName = "varchar(200)")]
        public string? Slug { get; set; }
        public int? Status { get; set; }
        public virtual ICollection<Products> Products { get; set; }
    }
}
