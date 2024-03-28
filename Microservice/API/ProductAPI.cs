using Microservice.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Microservice.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductAPI : ControllerBase
    {
        Product product = new Product();
        public ProductAPI() {
            product = new Product
            {
                Id = "prod_1",
                Category = "Electronics",
                Name = "Mobile",
                Description = "phones"
            };
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(product);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(product);
        }

        [HttpPost()]
        public IActionResult Post(Product product)
        {
            return Ok(product);
        }

        [HttpDelete ("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
