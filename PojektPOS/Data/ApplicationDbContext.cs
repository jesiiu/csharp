using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PojektPOS.Models;

namespace PojektPOS.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
                                    => optionsBuilder.UseSqlServer();

       public DbSet<Documents> Documents { get; set; }
       public DbSet<Products> Products { get; set; }
    }
}
