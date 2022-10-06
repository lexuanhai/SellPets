using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    [Table("Products")]
    public class Products : BaseEntity<int>
    {
        [Column(TypeName = "nvarchar(250)")]
        public string? Name { get; set; }
        public int? CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category? Category { get; set; }
        [Column(TypeName = "decimal(18,0)")]
        public decimal? Price { get; set; }
        [Column(TypeName = "nvarchar(max)")]
        public string? Description { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string? HairStyle { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string? Weight { get; set; }
        public int? Longevity { get; set; }
        public int? ReproductiveAge { get; set; } // tuổi sinh sản
        [Column(TypeName = "nvarchar(250)")]
        public string? NumberOfSpawns { get; set; }
        public int? Status { get; set; }
    }
}
