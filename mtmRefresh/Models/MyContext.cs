using Microsoft.EntityFrameworkCore;
namespace mtmRefresh.Models
{ 
    // the MyContext class representing a session with our MySQL 
    // database allowing us to query for or save data
    public class MyContext : DbContext 
    { 
        public MyContext(DbContextOptions options) : base(options) { }

        //MAKE SURE TO ADD YOUR MODELS HERE
        public DbSet<Game> Games { get; set; }
        public DbSet<Platform> Platforms { get; set; }
        public DbSet<Playable> Playables { get; set; }
        
    }
}