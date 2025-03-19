using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class PersonController : ControllerBase
    {

        [HttpGet("DiegoTesting")]
        public string DiegoTesting(string dameTuNombre)
        {
            var nombreObtenido = dameTuNombre;
            //String nombreObtenido = dameTuNombre;

            return "Hey There, your name is " + dameTuNombre;
            //return $"Hey There, you name is {dameTuNombre}"; 
        }


        [HttpGet("Getallproducts")]
        public string GetAllProducts()
        {
            //Modicafores de acceso 
            //Tipos de retorno de un metodo,void,string
            //Parametros
            //Swagger que es ? en un api como se relaciona 

            return "Todos los productos";
        }

        //2. Metodo GetProduct

        [HttpGet("GetProduct")]
        public IActionResult GetProduct(int id)
        {
            var product = new { Id = id, Name = "Product " + id };
            return Ok(product);
        }

        //3. Crear Una Lista de Productos 

        [HttpGet("GetProductsList")]
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