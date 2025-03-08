using Microsoft.EntityFrameworkCore;
using WorkerRegistration.Entities;

namespace WorkerRegistration.Data;

public class AppDbContext : DbContext
{
    public DbSet<Worker> Workers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseNpgsql(
                "Host=localhost;Port=5432;Database=container-postgres-db;Username=postgres;Password=12345;");
    }
}