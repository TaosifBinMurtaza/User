using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using User.BLL.DTOs;
using User.BLL.Services;

namespace User.ApplicationLayer.Controllers
{
	[Route("api/v{version:apiVersion}/[controller]")]
	[ApiController]
	//[ApiVersion("1.0")]
	[ApiVersion("2.0")]
	public class LoginController : ControllerBase
	{
		private LoginServices _loginServices;

		public LoginController(LoginServices loginServices)
		{
			_loginServices = loginServices;
		}
		[HttpPost]
		public async Task<IActionResult> Login([FromBody] LoginRequestDTO loginRequestDTO)
		{
			var data =await _loginServices.Login(loginRequestDTO);
			return Ok(data);
		}
	}
}
