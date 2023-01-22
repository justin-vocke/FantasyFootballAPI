using Microsoft.EntityFrameworkCore;

namespace FantasyFootballAPI.Data.Models
{
    public class FFContext: DbContext
    {
        public FFContext(DbContextOptions<FFContext> options) :base (options)
        {

        }

        public DbSet<Player> Player { get; set; }   

    }
}
