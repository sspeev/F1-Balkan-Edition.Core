using F1_Balkan_Edition.Infrastrucure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace F1_Balkan_Edition.Infrastrucure.Data
{
    public class F1BalkanEditionContext : DbContext
    {
        public F1BalkanEditionContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<Car> Cars { get; set; }
    }
}
