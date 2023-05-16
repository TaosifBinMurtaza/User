using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace User.DAL.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        //IEnumerable<T> GetAll();
        Task<IEnumerable<T>> GetAllAsync(string? includeProperties = null, int pageSize = 10, int pageNumber = 1);
		Task<T> GetAsync(Expression<Func<T, bool>> filter = null, string? includeProperties = null);
		Task CreateAsync(T entity);
	}
}
