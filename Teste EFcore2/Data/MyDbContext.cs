using Microsoft.EntityFrameworkCore;
using Teste_EFcore2.Models;

namespace Teste_EFcore2.Data;

public class MyDbContext : DbContext
{
    public DbSet<Post> Posts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase("MyDatabase");
    }
}