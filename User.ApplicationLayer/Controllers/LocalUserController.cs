using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using User.BLL.DTOs;
using User.BLL.Services;

namespace User.ApplicationLayer.Controllers
{
	[Route("api/v{version:apiVersion}/[controller]")]
	[ApiController]
	[ApiVersion("1.0")]
	[ApiVersion("2.0")]
	public class LocalUserController : ControllerBase
	{
		private LocalUserService _localuserService;
		private readonly ILogger<LocalUserController> _logger;

		public LocalUserController(LocalUserService localuserService, ILogger<LocalUserController> logger)
		{
			_localuserService = localuserService;
			_logger = logger;
		}
		[HttpGet]
		[Route("GetAllUser")]
		[MapToApiVersion("2.0")]
		//[Authorize(Roles ="Custom")]
		public async Task<IActionResult> GetAll()
		{
			return Ok(await _localuserService.GetAll());
		}
		[HttpGet("{id:int}")]
		[MapToApiVersion("2.0")]
		//[Authorize]
		public async Task<IActionResult> UserInformation(int id)
		{
			var data = await _localuserService.UserInformation(id);
			if(data==null)
			{
				return BadRequest("User Not fpund");
			}
			return Ok(data);
		}

		[HttpPost]
		[Route("User/Registration")]
		public async Task<IActionResult> CreateUser([FromBody] LocalUserDTO localuserDTO)
		{
			try
			{
				if (localuserDTO == null)
				{
					return BadRequest();
				}


				await _localuserService.CreateUser(localuserDTO);
				return Ok("User have been created");
			}
			catch (Exception)
			{
				return StatusCode(StatusCodes.Status500InternalServerError,
					"Error creating new employee record");
			}
		}

		//[HttpPut("{id:int}", Name = "UpdateUser")]
		[HttpPut]
		[Route("User/Update")]
		[Authorize(Roles = "User")]
		public async Task<IActionResult> UpdateUser(int id, [FromBody] LocalUserDTO localuserDTO)
		{
			var data = await _localuserService.UpdateUser(id, localuserDTO);
			if (data)
			{
				_logger.LogInformation("Updated");
				return Ok("Profile have been updated!!");
			}
			else
				return BadRequest("Error!Update is failed");
			
		}
	}
}
