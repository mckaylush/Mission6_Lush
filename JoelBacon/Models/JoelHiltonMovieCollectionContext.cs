using Microsoft.EntityFrameworkCore;

namespace Mission06_Lush.Models
{
    public class JoelHiltonMovieCollectionContext : DbContext
    {
        public JoelHiltonMovieCollectionContext(DbContextOptions<JoelHiltonMovieCollectionContext> options) : base(options) 
        { 
        
        }
        public DbSet<Movies> Movies { get; set; }

        public DbSet<Categories> Categories { get; set; }

    }
}
