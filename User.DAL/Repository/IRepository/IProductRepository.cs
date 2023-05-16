using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using User.DAL.Models;

namespace User.DAL.Repository.IRepository
{
    public interface IProductRepository:IRepository<Product>
    {
        // Task<IEnumerable<Product>> SearchByNameAsync(Expression<Func<Product,bool>>? filter = null);
        Task<IEnumerable<Product>> SearchByNameAsync(string name);
		

	}
}
