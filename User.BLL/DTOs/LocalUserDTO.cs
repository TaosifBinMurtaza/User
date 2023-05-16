﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User.BLL.DTOs
{
	public class LocalUserDTO
	{
		public int Id { get; set; }
		[Required]
		public string UserName { get; set; }
		[Required]
		public string Name { get; set; }
		[Required]
		public string Password { get; set; }
		[Required]
		public string Role { get; set; }
	}
}
