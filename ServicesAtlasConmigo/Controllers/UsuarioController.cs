using AtlasLibraries.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.SqlServer.Server;
using System.Globalization;
using System.Net;


namespace ServicesAtlasConmigo.Controllers  
{


    [ApiController]
    public class UsuarioController : ControllerBase
    {


        [Route("index")]
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("Hola Albert.");
        }

        [Route("saludo")]
        [HttpPost]
        public IActionResult ObtenerUsuario(string Nombre, int Edad)
        {
            //return BadRequest();
            string mensaje = "Tu nombre es:" + Nombre + "tu edad es: " + Edad;
            return Ok(mensaje);
        }

        [Route("entrada")]
        [HttpPost]
        public IActionResult Datos([FromBody] UsuarioModelInput input)
        {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }
            var output = new UsuarioModelOutput();
            /* output.Nombre = input.Nombre;
             output.Edad = input.Edad; 
             output.CorreoElectronico = input.CorreoElectronico;
             output.Estatus = input.Estatus;*/
            output.TodoElModelo = input;
        
            //var outpuNombre = output.TodoElModelo.Nombre

            return Ok(output);
        
        }

        [Route("persona")]
        [HttpPost]
        public IActionResult MensajePersona([FromBody] PersonaModelInput input)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            DateTime Day = DateTime.Today;
            //var age = Day.Year - input.FechaNacimiento.Year;
            DateTime anio = DateTime.Parse(input.FechaNacimiento);
            var age = Day.Year - anio.Year;
            
            
            var mensaje = "Hola mi nombre es " + input.Nombre + " tengo " + age ;
            //return Ok(mensaje);

            var objPersona = new PersonalModelOutput();
            objPersona.resultado = $"mensaje para el modelo de salida: {mensaje}"; /*asignamos a objPersona lo que tiene el mensaje*/
            return Ok(objPersona);
        }
    }
}
