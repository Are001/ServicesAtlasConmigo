using AtlasLibraries.Model;
using AtlasLibraries.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ServicesAtlasConmigo.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        //Instanciamos el servicio de categorias.
        public CategoriaServices _CategoriaServices;

        //Creamos el contructor
        public CategoriaController(CategoriaServices categoriaServices ) {
            this._CategoriaServices = categoriaServices;
        }


        [Route("ConsultaAllCategorias")]
        [HttpGet]
        public IActionResult Categorias() 
        {
            var resultado = _CategoriaServices.AllCategorias();
            //return Content(JsonConvert.SerializeObject(r));
            return Ok(resultado);
        }
        //recuerdar checar json dinamic.
        [Route("addCategoria")]
        [HttpPost]
        public IActionResult AddCategorias(CategoriaModelInsertInput input)
        {
            var resultado = _CategoriaServices.addCategoria(input);
            return Ok(resultado);

        }

     

    }
}
