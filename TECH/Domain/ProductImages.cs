using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Table("ProductImages")]
    public class ProductImages
    {
        [Key]
        public int Id { get; set; }               
        public int? ProductId { get; set; }
        [Column(TypeName = "varchar(500)")]
        public string? Images { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
