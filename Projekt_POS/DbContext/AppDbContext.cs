using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Document> Documents { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite(@"Data Source = ..\..\..\Database\pos.db"); //Dla działania
    /*      => optionsBuilder.UseSqlite(@"Data Source = .\Database\pos.db");*/ //Dla update
}

