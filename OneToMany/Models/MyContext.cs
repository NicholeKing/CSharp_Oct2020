using Microsoft.EntityFrameworkCore;

namespace OneToMany.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }
        public DbSet<Octopus> Octopi { get; set; }
        public DbSet<Tentacle> Tentacles{get;set;}
    }
}