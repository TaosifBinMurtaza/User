using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.DAL.Models;

namespace User.DAL.Repository.IRepository
{
	public interface IUserRepository:IRepository<LocalUser>
	{
		Task<LocalUser> UpdateAsync(LocalUser entity);
		bool IsUniqueUser(string name);
		Task<Login> Login(Login user);
	}
}
