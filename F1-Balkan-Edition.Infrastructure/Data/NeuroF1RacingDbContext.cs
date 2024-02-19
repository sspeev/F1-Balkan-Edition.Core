using F1_Balkan_Edition.Infrastrucure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace F1_Balkan_Edition.Infrastrucure.Data
{
    public class NeuroF1RacingDbContext : DbContext
    {
        public NeuroF1RacingDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<Car> Cars { get; set; }
    }
}
