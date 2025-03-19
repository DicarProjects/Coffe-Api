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

   
        public List<string> GetProductsList()
        {
            return new List<string>
            {
                "Arroz",
                "Frijoles",
                "Aceite",
                "Azúcar"
            };
        }

    }
}