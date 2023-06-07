using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TeamBuilderAPI.Interfaces;

namespace TeamBuilderAPI.Models
{
    public class ApplicationDbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IConfiguration configuration) : base(options) 
        {
            _configuration = configuration;
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get;set; }
        public DbSet<EventCentre> EventCentres { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<TeamBuilding> TeamBuildings { get; set; }
        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EventCentre>().HasData(
                new EventCentre { CentreName = "Carting Sky Cart", Capacity = 50, Id = Guid.NewGuid(), Address = "Unnamed Road, Volkovo" },
                new EventCentre { CentreName = "Kayak Rental - Matka", Capacity = 20, Id = Guid.NewGuid(), Address = "Planinarski Dom Matka Matka, 1060" },
                new EventCentre { CentreName = "Paintball Arena BEST", Capacity = 50, Id = Guid.NewGuid(), Address = "Justinijan Prvi, Drachevo" }
                );
            modelBuilder.Entity<Restaurant>().HasData(
               new Restaurant { RestaurantName = "Gostilnica Dukat", Capacity = 60, Location = "Teodosij Gologanov 79", Id = Guid.NewGuid() },
               new Restaurant { RestaurantName = "Dva Elena", Capacity = 90, Location = "Zagrebska 31, Skopje", Id = Guid.NewGuid() },
               new Restaurant { RestaurantName = "Makedonska Kuka", Capacity = 60, Location = "Teodosie Gologanov no.63, Skopje", Id = Guid.NewGuid() }
               );
        }
      
        public DbSet<Team> Teams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            var connectionString = _configuration.GetConnectionString("DefaultConnection");

            optionsBuilder.UseSqlServer(connectionString);
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            var currentUserId = Guid.Parse("533f0f57-0399-4021-8d3e-f41b16196b79");

            foreach (var entry in ChangeTracker.Entries<IAuditableEntity>().ToList())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedOn = DateTime.UtcNow;
                        entry.Entity.CreatedBy = currentUserId;
                        entry.Entity.LastModifiedBy = currentUserId; break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedOn = DateTime.UtcNow;
                        entry.Entity.LastModifiedBy = currentUserId;
                        break;
                }
            }
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

    }
}
