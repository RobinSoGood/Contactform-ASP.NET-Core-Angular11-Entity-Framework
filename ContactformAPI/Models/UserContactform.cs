using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContactformAPI.Models
{
    public class UserContactform
    {

        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string UserName { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string UserEmail { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string UserTelephone { get; set; }
    }
}

