using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.DAL.Models;

namespace User.BLL.DTOs
{
	public class LoginResponseDTO
	{
		public LocalUser User { get; set; }
		public string Token { get; set; }
	}
}
