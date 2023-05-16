using Frontend.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Text.Json.Serialization;
using User.DAL.Models;

namespace Frontend.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        Uri baseAddress = new Uri("https://localhost:44383/api/v1");
        private readonly HttpClient _clint;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _clint = new HttpClient();
            _clint.BaseAddress = baseAddress;
        }

        [HttpGet]
        public async Task<IActionResult>  Index()
        {
            List<Product> productList = new List<Product>();
            HttpResponseMessage response = await _clint.GetAsync(_clint.BaseAddress + "/Product/GetAllProduct");
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                productList = JsonConvert.DeserializeObject<List<Product>>(data);
            }

            return View(productList);
        }
        [HttpGet]
        public async Task<IActionResult> Privacy()
        {
            List<Product> productList = new List<Product>();
            HttpResponseMessage response =await _clint.GetAsync(_clint.BaseAddress + "/Product/GetAllProduct");
            if(response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                productList = JsonConvert.DeserializeObject<List<Product>>(data);
            }

            return View(productList);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}