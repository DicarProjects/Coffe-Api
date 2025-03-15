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

        [HttpGet("{id}")]
        public string GetProduct(int id) 
        {

            // Modicafores de acceso 
            // Clases
            // Expresión Ternaria 
            // Funciones de flecha vs funcion c# 
            // que es un Objeto 
            // Parametros

            return "producto" + id;

        } 

        //3. Crear Una Lista de Productos 
    }
}