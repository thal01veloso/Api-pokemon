using Microsoft.EntityFrameworkCore;
using models;

namespace context
{
    public class PokemonContext : DbContext
    {
        
        
        public  PokemonContext(DbContextOptions<PokemonContext> options) : base(options)
        {

        }
        public DbSet<Pokemon> Pokemons{set;get;}
    }
}