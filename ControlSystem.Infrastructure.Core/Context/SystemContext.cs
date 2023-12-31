using ControlSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ControlSystem.Infrastructure.Context;

public sealed class SystemContext : DbContext
{
    public SystemContext(DbContextOptions<SystemContext> options) : base(options) { }

    public DbSet<Person> People { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(SystemContext).Assembly);
    }
}
