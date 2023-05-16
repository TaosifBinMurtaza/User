using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using User.BLL;
using User.BLL.DTOs;
using User.BLL.Services;


namespace User.ApplicationLayer.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    public class ProductController : ControllerBase
    {
        private ProductService _productService;

        public ProductController(ProductService productService)
        {
            _productService = productService;
        }


        [HttpGet]
        [Route("GetAllProduct")]
        public async Task<IActionResult>  GetAll(int pageSize = 10, int pageNumber = 1)
        {
            //_response.Result = await _productService.GetAll();
            //_response.StatusCode = HttpStatusCode.OK;
            //return Ok(_response);
             return Ok( await _productService.GetAll(pageSize: pageSize, pageNumber: pageNumber));
        }

        [HttpGet]
        [Route("SearchByName")]
        [ResponseCache(Duration =30)]
        public async Task<IActionResult> SearchByName(string? name)
        {
            var data = await _productService.SearchByName(name);
            return Ok(data);
        }



    }
}
