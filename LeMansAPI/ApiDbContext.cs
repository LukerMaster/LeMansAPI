using LeMansAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LeMansAPI
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
        }
        public DbSet<Race> Races { get; set; }
        public DbSet<RaceEntryResult> RaceEntryResults { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<PitStop> PitStops { get; set; }
    }
}
