using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.DAL.Models;

namespace User.BLL.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        public string Author { get; set; }

        public double ListPrice { get; set; }

        public double Price { get; set; }
        public string ImageUrl { get; set; }

        [Required]
        public int CategoryId { get; set; }
        public Category category { get; set; }
        [Required]
        public int CompanyId { get; set; }
        public Company company { get; set; }
    }
}
