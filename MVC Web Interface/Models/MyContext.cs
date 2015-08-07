using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Web_Interface.Models
{
    public class MyContext : DbContext
    {
        public DbSet<Pupil> Pupils { get; set; }
        public DbSet<AdultPerson> Adults { get; set; }
    }
}
