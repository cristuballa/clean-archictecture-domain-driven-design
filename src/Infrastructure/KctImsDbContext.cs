using Domain.Entities;
using Domain.Items;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class KctImsDbContext : DbContext
{
    public KctImsDbContext(DbContextOptions<KctImsDbContext> options) : base(options)
    {
    }
    public DbSet<User> Users { get; set; }
    public DbSet<Item> Items { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(KctImsDbContext).Assembly);
    }
}