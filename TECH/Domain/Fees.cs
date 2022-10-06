using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace Domain
{
    [Table("Fees")]
    public class Fees : BaseEntity<int>
    {
        public int? City_id { get; set; }
        [ForeignKey("City_id")]
        public City? City { get; set; }

        public int? District_id { get; set; }
        [ForeignKey("District_id")]
        public Districts? Districts { get; set; }

        public int? Ward_id { get; set; }
        [ForeignKey("Ward_id")]
        public Wards? Wards { get; set; }
        [Column(TypeName = "decimal(18,0)")]
        public decimal? fee { get; set; }

    }
}
