using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiVersioningTask.Controllers
{
    [Route("api/v{version:apiVersion}/products")]
    [ApiVersion("2.0")]
    [ApiController]
    public class ProductsV2Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = new[]
            {
                new {ID = 1, Name = "Laptop", Price = 25000, CategoryName = "Electronics"}
            };

            return Ok(products);
        }
    }
}
