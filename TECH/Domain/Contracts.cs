using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{

    [Table("Contacts")]
    public class Contracts : BaseEntity<int>
    {
        [Column(TypeName = "nvarchar(250)")]
        public string? Full_name { get; set; }

        [Column(TypeName = "varchar(11)")]
        public string? Phone_number { get; set; }

        [Column(TypeName = "text")]
        public string? Note { get; set; }

        public int? Status { get; set; }

    }
}
