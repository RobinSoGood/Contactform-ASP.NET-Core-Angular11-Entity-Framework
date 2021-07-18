using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContactformAPI.Models
{
    public class ContactformDb
    {
        [Key]
        public int ContactformDbId { get; set; }


        [Column(TypeName = "nvarchar(500)")]
        public string DbMessage { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string Theme { get; set; }

        [Column(TypeName = "int")]
        public int UserContactformId { get; set; }
        public UserContactform UserContactform { get; set; }
    }
}
