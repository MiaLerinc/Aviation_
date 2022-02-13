using DomainModel.Models;
using Microsoft.EntityFrameworkCore;

namespace AviationWebAPI.DatabaseContext
{
    public class AviationContext : DbContext
    {
        public AviationContext(DbContextOptions<AviationContext> dbContextOptions)
: base(dbContextOptions)
        {
        }
        public DbSet<Airport> Airports { get; set; }
        public DbSet<Country> Countries { get; set; }
    }
}
