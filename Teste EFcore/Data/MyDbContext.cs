using Microsoft.EntityFrameworkCore;

namespace Teste_EFcore.Data;

public class MyDbContext : DbContext
{
    // cria uma tabela no banco de dados
    public DbSet<Purchase> Purchases { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase("Database");
    }
}