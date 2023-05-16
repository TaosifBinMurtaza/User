using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.DAL.Models;

namespace User.DAL.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category>Categories{ get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<LocalUser> LocalUsers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            for (int i = 1; i <= 100; i++)
            {
                modelBuilder.Entity<Product>().HasData(
                     new Product
                     {
                         Id = i,
                         Title = "Book"+ "Title" + i,
                         Description = "The book description goes most prominently on the back cover, and the top of your Amazon page (below the price and above the book reviews). It’s crucial it be compelling, because readers make buying decisions from the book description.",
                         ISBN = "ISBN" + i,
                         Author = "Name" + 1,
                         ListPrice = GenerateRandomListPrice(),
                         Price = GenerateRandomPrice(),
                         ImageUrl = "\\images\\products\\Book.png",
                         CategoryId = 1,
                         CompanyId = 1,
                     });
            }
        }

        private double GenerateRandomPrice()
        {
            // Generate random price between 10 and 100
            var random = new Random();
            return Math.Round(random.Next(150, 500) + random.NextDouble(), 2);
        }
		private double GenerateRandomListPrice()
		{
			// Generate random price between 10 and 100
			var random = new Random();
			return Math.Round(random.Next(10, 150) + random.NextDouble(), 2);
		}
	}
}
