using CQRS.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRS.Contexts
{
  public partial class AppDbContext : DbContext
  {
    public DbSet<Product> Products { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
          .HasCharSet("utf8mb4");

      modelBuilder.Entity<Product>();

      OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
  }
}
