using Microsoft.EntityFrameworkCore;

namespace bot_System_of_Sales_Store.Models;

public class ModelContext : DbContext
{
    

    public DbSet<Produtos> Produtos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        const string connectionString = "User ID=postgres;Password=@1618;Host=localhost;Port=5432;Database=Produtos;Pooling=true;Connection Lifetime=0;";
        builder.UseNpgsql(connectionString);
    }

}