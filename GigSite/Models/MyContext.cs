using Microsoft.EntityFrameworkCore;
namespace GigSite.Models
{ 
    // the MyContext class representing a session with our MySQL 
    // database allowing us to query for or save data
    public class MyContext : DbContext 
    { 
        public MyContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users {get;set;}
        public DbSet<Gig> Gigs {get;set;}
        public DbSet<OrderHistory> Orders {get;set;}
    }
}