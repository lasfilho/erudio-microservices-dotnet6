using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class MySQLContext: DbContext
    {
        public MySQLContext() { }
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options){ }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Geek Picture",
                Price = new decimal (10.90),
                Description = "Foto com logo Geek",
                ImageURL = "",
                CategoryName = "Photo"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Geek NoteBook",
                Price = new decimal(49.90),
                Description = "NoteBook com logo Geek",
                ImageURL = "",
                CategoryName = "Material Escolar"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Geek Brush",
                Price = new decimal(15.90),
                Description = "Escova com logo Geek",
                ImageURL = "",
                CategoryName = "Vestuario"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Geek Cake",
                Price = new decimal(12.90),
                Description = "Bolo com logo Geek",
                ImageURL = "",
                CategoryName = "Alimento"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "Geek Glass",
                Price = new decimal(90.90),
                Description = "Oculos com logo Geek",
                ImageURL = "",
                CategoryName = "Vestuario"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 8,
                Name = "Geek Short",
                Price = new decimal(69.90),
                Description = "Bermuda com logo Geek",
                ImageURL = "",
                CategoryName = "Vestuario"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 9,
                Name = "Geek Gloves",
                Price = new decimal(20.90),
                Description = "Luvas com logo Geek",
                ImageURL = "",
                CategoryName = "Vestuario"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 10,
                Name = "Geek Hat",
                Price = new decimal(69.90),
                Description = "Bone com logo Geek",
                ImageURL = "",
                CategoryName = "Vestuario"
            });
        }
    }
}
