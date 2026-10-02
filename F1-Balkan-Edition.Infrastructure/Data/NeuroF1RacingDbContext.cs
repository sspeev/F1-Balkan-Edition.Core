namespace F1_Balkan_Edition.Infrastrucure.Data;

public class NeuroF1RacingDbContext(DbContextOptions options) : DbContext(options), DbContext
{
    public DbSet<User> Users { get; set; }

    public DbSet<Car> Cars { get; set; }
}
