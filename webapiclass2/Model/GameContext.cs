using Microsoft.EntityFrameworkCore;

namespace webapiclass2.Model
{
    public class GameContext:DbContext
    { 
       public GameContext(DbContextOptions options):base (options)
        {

        }
        public DbSet<Player> Players { get; set; }
    }
}
