using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactformAPI.Models
{
    public class ContactformDetailContext:DbContext
    {
        public ContactformDetailContext(DbContextOptions<ContactformDetailContext> options):base(options){}

        public DbSet<ContactformDetail> ContactformDetails { get; set; }
        public DbSet<UserContactform> UserContactforms { get; set; }
        public DbSet<ContactformDb> ContactformDbs { get; set; }
        public DbSet<Themes> Themes { get; set; }
    }
}
