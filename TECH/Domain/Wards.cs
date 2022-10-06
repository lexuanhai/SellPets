using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace Domain
{
    [Table("wards")]
    public class Wards : BaseEntity<int>
    {
        public int? DistrictId { get; set; }
        [ForeignKey("district_id")]
        public Districts? Districts { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string? Name { get; set; }
    }
}
