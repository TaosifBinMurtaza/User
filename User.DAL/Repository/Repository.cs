using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using User.DAL.Data;
using User.DAL.Repository.IRepository;

namespace User.DAL.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        internal DbSet<T> dbset;
        public Repository(ApplicationDbContext db)
        {
            _db = db;
            dbset = _db.Set<T>();
        }

		public async Task CreateAsync(T entity)
		{
			await dbset.AddAsync(entity);
		}

		public async Task<IEnumerable<T>> GetAllAsync(string? includeProperties = null, int pageSize = 10, int pageNumber = 1)
        {
            IQueryable<T> query = dbset;
			query=query.Skip(pageSize*(pageNumber-1)).Take(pageSize);
            if (includeProperties != null)
            {
                foreach (var includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProp);
                }
            }
            return await query.ToListAsync();
        }

		public async Task<T> GetAsync(Expression<Func<T, bool>> filter = null, string? includeProperties = null)
		{
			IQueryable<T> query = dbset;
			if (filter != null)
			{
				query = query.Where(filter);
			}

			if (includeProperties != null)
			{
				foreach (var includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
				{
					query = query.Include(includeProp);
				}
			}
			return await query.FirstOrDefaultAsync();
		}

	}
}
