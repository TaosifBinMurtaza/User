using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using User.DAL.Data;
using User.DAL.Models;
using User.DAL.Repository.IRepository;

namespace User.DAL.Repository
{
	public class UserRepository:Repository<LocalUser>,IUserRepository
	{
		private readonly ApplicationDbContext _db;
		private string secretKey;
		public UserRepository(ApplicationDbContext db, IConfiguration configuration) : base(db)
		{
			 
			_db = db;
			secretKey = configuration.GetValue<string>("ApiSettings:Secret");
		}

		public bool IsUniqueUser(string name)
		{
			var data=_db.LocalUsers.FirstOrDefault(x => x.Name == name);
			if(data== null) return true;	
			return false;
		}

		public async Task<Login> Login(Login entity)
		{
			var user = _db.LocalUsers.FirstOrDefault(u => u.UserName == entity.UserName && u.Password == entity.Password);
			if (user == null)
			{
				return null;
			}

			//Token
			var tokenHandler = new JwtSecurityTokenHandler();
			var key = Encoding.ASCII.GetBytes(secretKey);
			var tokenDescriptor = new SecurityTokenDescriptor
			{
				Subject = new ClaimsIdentity(new Claim[]
			   {
					new Claim(ClaimTypes.Name, user.UserName.ToString()),
					new Claim(ClaimTypes.Role,user.Role)
			   }),
				Expires = DateTime.UtcNow.AddDays(7),
				SigningCredentials = new(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
			};
			var token = tokenHandler.CreateToken(tokenDescriptor);

			Login login = new Login()
			{
				//UserName = entity.UserName,
				Token = tokenHandler.WriteToken(token),
				User = entity.User,

			};

			return login;

			
		}

		public async Task<LocalUser> UpdateAsync(LocalUser entity)
		{
			 _db.LocalUsers.Update(entity);
			return  entity;
		}
	}
}
