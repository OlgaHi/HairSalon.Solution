using Microsoft.EntityFrameworkCore;

namespace HairSalon.Models
{
  public class HairSalonContext : DbContext
  {
    public virtual DbSet<Stylyst> Stylyst { get; set; }
    // public DbSet<Item> Items { get; set; }

    public HairSalonContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}