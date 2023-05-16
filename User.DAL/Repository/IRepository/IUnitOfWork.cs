using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.DAL.Repository.IRepository
{
    public interface IUnitOfWork
    {
       IProductRepository ProductRepo { get; }
       IUserRepository UserRepo { get; }
       Task SaveAsync();
    }
}
