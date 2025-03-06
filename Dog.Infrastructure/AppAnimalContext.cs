using Animal.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Animal.Infrastructure
{
    public class AppAnimalContext : DbContext
    {
        public DbSet<Specie> Species { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=ep-quiet-bread-a5cmt5iu-pooler.us-east-2.aws.neon.tech;Database=neondb;Username=neondb_owner;Password=npg_w9o0EOlJUrAB;");
        }
    }
}
