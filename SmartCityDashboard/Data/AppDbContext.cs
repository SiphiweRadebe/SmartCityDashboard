using Microsoft.EntityFrameworkCore;

namespace SmartCityDashboard.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TrafficEvent> TrafficEvents { get; set; }
    }
}
