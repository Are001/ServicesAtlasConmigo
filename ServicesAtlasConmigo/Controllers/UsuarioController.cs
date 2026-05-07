using AtlasLibraries.Model;
using AtlasLibraries.Services;
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
        //Tipo                  -nombre de la variable 
        public UsuarioServices _UsuarioServices;

        public UsuarioController( UsuarioServices usuarioServicio)
        {
              this._UsuarioServices = usuarioServicio;
        }


       /* [Route("index")]
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
         //   output.TodoElModelo = input;
        
            //var outpuNombre = output.TodoElModelo.Nombre

           // return Ok(output);
        
        //}

        [Route("persona")]
        [HttpPost]
        //Entrada
        public IActionResult MensajePersona([FromBody] PersonaModelInput input)
        {
           

            var llamar = _UsuarioServices.CalcularAnios(input);
            return Ok(llamar);
           
        }

        [Route("consultaUsuario")]
        [HttpGet]
        public IActionResult ConsultaUsurio() {
             var output = _UsuarioServices.AllUsuarios();
            return Ok(output);
        }   
    }
}
