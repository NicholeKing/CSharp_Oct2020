using Microsoft.EntityFrameworkCore;

namespace loginregister.Models
{ 
    // the MyContext class representing a session with our MySQL 
    // database allowing us to query for or save data
    public class MyContext : DbContext 
    { 
        public MyContext(DbContextOptions options) : base(options) { }

        //MAKE SURE TO ADD YOUR MODELS HERE
        public DbSet<User> Users { get; set; }
    }
}