using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContactformAPI.Models
{
    public class ContactformDetail
    {
        [Key]
        [Required]
        public int ContactformDetailId { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Required]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(25)")]
        [Required]
        public string Email { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        [Required]
        public string Telephone { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        [Required]
        public string Theme { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        [Required]
        public string Message { get; set; }

    }
}

