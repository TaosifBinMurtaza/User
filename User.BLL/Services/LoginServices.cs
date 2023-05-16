using AutoMapper;
using Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using User.BLL.DTOs;
using User.DAL.Models;
using User.DAL.Repository.IRepository;

namespace User.BLL.Services
{
	public class LoginServices
	{
		private readonly IUnitOfWork _unit;
		private readonly IMapper _mapper;

		public LoginServices(IMapper mapper, IUnitOfWork unit)
		{
			_unit = unit;
			_mapper = mapper;
		}
		public async Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO)
		{

			Login login = _mapper.Map<Login>(loginRequestDTO);
			var data = await _unit.UserRepo.Login(login);
			return  _mapper.Map<LoginResponseDTO>(data);
		}
	}
}
