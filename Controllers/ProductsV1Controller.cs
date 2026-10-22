using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiVersioningTask.Controllers
{
    [Route("api/v{version:apiVersion}/products")]
    [ApiVersion("1.0")]
    [ApiController]
    public class ProductsV1Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = new[]
            {
                new { ID = 1, Name = "Laptop", Price = 25000}
            };


            return Ok(products);
        }
    }
}
