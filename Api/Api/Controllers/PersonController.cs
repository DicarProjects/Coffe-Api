using Api.models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class PersonController : ControllerBase
    {

        [HttpGet("GetAllProducts")]
        public string GetAllProducts()
        {
            return "Todos los productos";
        }

        [HttpGet("GetProductById")]
        public IActionResult GetProduct(int id)
        {
            var product = new { Id = id, Name = "Product " + id };
            return Ok(product);
        }

        [HttpPost("AddProduct")]
        public IActionResult AddProduct()
        {
            return Ok();
        }

        [HttpPut("UpdateProduct")]
        public IActionResult Update()
        {
            return Ok();
        }

        [HttpDelete("DeleteProduct")]
        public IActionResult Delete()
        {
            return Ok();
        }

        private List<Product> GetProductList()
        {
            return new List<Product>
            {
            new Product { Id = 1, Name = "Arroz", IsAvailable = true },
            new Product { Id = 2, Name = "Aceite", IsAvailable = true },
            new Product { Id = 3, Name = "Frijol", IsAvailable = true }
            };
        }

    }
}