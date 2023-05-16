using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.DAL.Data;
using User.DAL.Repository.IRepository;

namespace User.DAL.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db, IConfiguration configuration)
        {
            _db = db;
            ProductRepo = new ProductRepository(_db);
            UserRepo= new UserRepository(_db, configuration);  
                
        }
        public IProductRepository ProductRepo { get; set; }

		public IUserRepository UserRepo { get; set; }


		public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();
        }

        //public void Save()
        //{
        //    _db.SaveChanges();
        //}
    }
}
