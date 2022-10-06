using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Table("ProductQuantity")]
    public class ProductQuantity
    {
        [Key]
        public int Id { get; set; }                       
        public int? TotalImported { get; set; }
        public int? TotalSold { get; set; }
        public int? TotalStock { get; set; }

        // các trường khóa ngoại
        public int? AppColorId { get; set; }
        [ForeignKey("AppColorId")]
        public AppColor? AppColor { get; set; }
        public int? ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Products? Products { get; set; }
        public bool IsDeleted { get; set; }
    }
}
