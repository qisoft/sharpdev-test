using System.Data.Entity;

namespace DataLayer.Models
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Teacher> Teachers { get; set; } 
        public DbSet<AdultPerson> Adults { get; set; }
        public DbSet<Phone> Phones { get; set; } 
    }
}
