using Microsoft.EntityFrameworkCore;

namespace ReservationSystem_API.Data
{
    public class AppDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public AppDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // connect to postgres with connection string from app settings
            optionsBuilder
                .UseNpgsql(Configuration.GetConnectionString("WebApiDatabase"))
                .UseSnakeCaseNamingConvention();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // idx colume을 GENERATED ALWAYS AS IDENTITY(auto-increment) 값으로 변경
            modelBuilder.Entity<Facility>().Property(b => b.Idx).UseIdentityAlwaysColumn();     
        }

        public DbSet<Facility> Facilities { get; set; }
    }
}
