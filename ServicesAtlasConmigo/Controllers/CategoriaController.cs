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
        public CategoriaServices _CategoriaServices;

        public CategoriaController(CategoriaServices categoriaServices ) {
            this._CategoriaServices = categoriaServices;
        }

        [Route("consultaAllCategorias")]
        [HttpGet]
        public IActionResult Categorias() 
        {
            var r = _CategoriaServices.AllCategorias();
            //return Content(JsonConvert.SerializeObject(r));
            return Ok(r);
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
