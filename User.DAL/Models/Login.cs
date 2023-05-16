using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.DAL.Models
{
	public class Login
	{
		public string UserName { get; set; }
		public string Password { get; set; }

		public LocalUser User { get; set; }
		public string Token { get; set; }
	}
}
