using Microsoft.EntityFrameworkCore;
using TestInterviewApp.Models;
namespace TestInterviewApp.Data
{
    public class EcommerceDbContext : DbContext
    {
        public EcommerceDbContext(DbContextOptions<EcommerceDbContext> options) : base(options) { }

        public DbSet<Products> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            // Seeding Data 
            modelBuilder.Entity<Products>().HasData(
                new Products
                {
                    Id = 1,
                    nama = "Produk 1",
                    harga = 20000,
                    gambar ="Product-1.png"
                },
                new Products
                {
                    Id = 2,
                    nama = "Produk 2",
                    harga = 35000,
                    gambar ="Product-2.png"
                },
                 new Products
                 {
                     Id = 3,
                     nama = "Produk 3",
                     harga = 30000,
                     gambar = "Product-3.png"
                 },
                new Products
                {
                    Id = 4,
                    nama = "Produk 4",
                    harga = 45000,
                    gambar = "Product-4.png"
                },
                 new Products
                 {
                     Id = 5,
                     nama = "Produk 5",
                     harga = 50000,
                     gambar = "Product-5.png"
                 },
                new Products
                {
                    Id = 6,
                    nama = "Produk 6",
                    harga = 25000,
                    gambar = "Product-6.png"
                }
                );
        }
    }
}
