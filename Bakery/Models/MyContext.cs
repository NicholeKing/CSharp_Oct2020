using Microsoft.EntityFrameworkCore;
namespace Bakery.Models
{ 
    // the MyContext class representing a session with our MySQL 
    // database allowing us to query for or save data
    public class MyContext : DbContext 
    { 
        public MyContext(DbContextOptions options) : base(options) { }

        //MAKE SURE TO ADD YOUR MODELS HERE
        public DbSet<Shop> Shops {get;set;}
        public DbSet<Good> Goods {get;set;}
        public DbSet<Inventory> Stock {get;set;}
        
    }
}