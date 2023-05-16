using AutoMapper;
using Azure;
using Microsoft.EntityFrameworkCore;
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
    public class LocalUserService
    {
        private readonly IUnitOfWork _unit;
        private readonly IMapper _mapper;
        public LocalUserService(IMapper mapper, IUnitOfWork unit)
        {
            _unit = unit;
            _mapper = mapper;
        }
		public async Task<IEnumerable<LocalUserDTO>> GetAll()
		{
			var data = await _unit.UserRepo.GetAllAsync();
			return _mapper.Map<IEnumerable<LocalUserDTO>>(data);
		}

		public async Task  CreateUser(LocalUserDTO localuserDTO)
		{
			LocalUser localUser = _mapper.Map<LocalUser>(localuserDTO);
			await _unit.UserRepo.CreateAsync(localUser);
			await _unit.SaveAsync();
		}
		public async Task<bool> UpdateUser(int id,LocalUserDTO localuserDTO)
		{
			LocalUser localUser = _mapper.Map<LocalUser>(localuserDTO);
			if(localUser==null||id!=localuserDTO.Id)
			{
				return false;
			}
			await _unit.UserRepo.UpdateAsync(localUser);
			await _unit.SaveAsync();
			return true;
		}

		public async Task<LocalUserDTO> UserInformation(int id)
		{
			var data = await _unit.UserRepo.GetAsync(u=>u.Id==id);
			return _mapper.Map<LocalUserDTO>(data);

		}

	}
}
