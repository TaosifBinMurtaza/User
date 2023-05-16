using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.BLL.DTOs;
using User.DAL.Models;

namespace User.BLL
{
    public class MappingConfig :Profile
    {
        public MappingConfig()
        {
            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<LocalUser, LocalUserDTO>().ReverseMap();
            CreateMap<Login, LoginDTO>().ReverseMap();
			CreateMap<Login, LoginRequestDTO>().ReverseMap();
			CreateMap<Login, LoginResponseDTO>().ReverseMap();
		}
    }
}
