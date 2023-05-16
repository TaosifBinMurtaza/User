using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using User.DAL.Data;
using User.DAL.Models;
using User.DAL.Repository.IRepository;

namespace User.DAL.Repository
{
    public class ProductRepository:Repository<Product> ,IProductRepository
    {
        private readonly ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Product>> SearchByNameAsync(string name)
        {
            IQueryable<Product> query = _db.Products;

            
                // query = query.Where(u => u.Title.ToLower() == name.ToLower());
            query = query.Where(e => e.Title.Contains(name));
            
            return await query.ToListAsync();

        }
    }
}
