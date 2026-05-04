using AtlasLibraries.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ServicesAtlasConmigo.Controllers
{
   
    [ApiController]
    public class EjemploController : ControllerBase
    {
        [Route("ejemplo")]
        [HttpGet]
        //intente traerlo con el HttpsGet
        public IActionResult ObtenerAuto([FromBody] EjemplosModel  input) 
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(input);

        }

        [Route("ejemploObj")]
        [HttpGet]
        //intente traerlo con el HttpsGet
        public IActionResult ObtenerAutoObj([FromBody] EjemplosModel input)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(input);

        }
    }
}
