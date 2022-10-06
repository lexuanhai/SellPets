using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{

    [Table("Users")]
    public class Users : BaseEntity<int>
    {
        //[Key]
        //public int Id { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string? Full_Name { get; set; }

        [Column(TypeName = "varchar(11)")]
        public string? Phone_Number { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string? Email { get; set; }

        [Column(TypeName = "varchar(500)")]
        public string? Avatar { get; set; }

        [Column(TypeName = "varchar(10)")]
        public string? Code { get; set; }
        [Column(TypeName = "nvarchar(500)")]
        public string? Address { get; set; }

        public int? Role { get; set; }

        [Column(TypeName = "varchar(32)")]
        public string? Password { get; set; }

        public int? Status { get; set; }


    }
}
