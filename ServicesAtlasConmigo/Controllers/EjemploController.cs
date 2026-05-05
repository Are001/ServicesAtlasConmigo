using AtlasLibraries.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using System.Reflection;

namespace ServicesAtlasConmigo.Controllers
{
   
    [ApiController]
    public class EjemploController : ControllerBase
    {
        public EjemploController()
        {
                      
        }

        [Route("ejemploArray")]
        [HttpGet]
        //intente traerlo con el HttpsGet
        public ActionResult<List<EjemplosModel>> Get()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var Ejemplo = new List<EjemplosModel>
            {
                new EjemplosModel{Modelo=2020, Color="rojo",Marca="Nissan", TipoMotor="Gasolina"},
                new EjemplosModel{Modelo=2021, Color="rojo",Marca="Nissan", TipoMotor="Gasolina"},
                new EjemplosModel{Modelo=2022, Color="rojo",Marca="Nissan", TipoMotor="Gasolina"}
            };

            return Ok(Ejemplo);

        }

       

        [Route("ejemploObj")]
        [HttpPost]
        //intente traerlo con el HttpsGet
        public IActionResult ObtenerAutoObj([FromBody] EjemploModelOutput output)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            //declaramos un  objeto
            EjemploModelOutput salidaAuto = new EjemploModelOutput();
            salidaAuto.NumeroPuertas = 4;
           
            return Ok(output);

        }
    }
}
