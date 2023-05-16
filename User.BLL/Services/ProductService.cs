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
using User.DAL.Repository.IRepository;

namespace User.BLL.Services
{
    public class ProductService
    {
        private readonly IUnitOfWork _unit;
        private readonly IMapper _mapper;
        public ProductService(IMapper mapper, IUnitOfWork unit)
        {
            _unit = unit;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductDTO>> GetAll(int pageSize = 10, int pageNumber = 1)
        {
            var data = await _unit.ProductRepo.GetAllAsync(includeProperties: "category,company",pageSize:pageSize,pageNumber:pageNumber);
            return _mapper.Map<IEnumerable<ProductDTO>>(data);

            //var data = await _unit.ProductRepo.GetAllAsync();
            //_response.Result = _mapper.Map<IEnumerable<ProductDTO>>(data);
            //_response.StatusCode = HttpStatusCode.OK;
            //_response.IsSuccess = true;
            //return (IEnumerable<ProductDTO>)_response;
        }

        public async Task<IEnumerable<ProductDTO>> SearchByName(string? name)
        {
            var data=await _unit.ProductRepo.SearchByNameAsync(name);
            return _mapper.Map<IEnumerable<ProductDTO>>(data);
        }

    }
}
