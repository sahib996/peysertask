using Microsoft.EntityFrameworkCore;
using MultiShop.Models;


namespace MultiShop.DataAccesLayer
{
    public class MultiShopContext : DbContext
    {
        public MultiShopContext(DbContextOptions options) : base(options)
        {           
        }
        public DbSet<Color> Colors  { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-GNV6364\\SQLEXPRESS;DataBase=MultiShop;Trusted_Connection=true;TrustServerCertificate=true");
            base.OnConfiguring(optionsBuilder);     
        }
    }
}
