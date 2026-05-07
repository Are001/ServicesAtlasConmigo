using AtlasLibraries.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
            var output = _CategoriaServices.AllCategorias();
            return Ok(output);

        }

        [Route("addCategoria")]
        [HttpPost]
        public IActionResult AddCategorias()
        {
            var output = _CategoriaServices.addCategoria();
            return Ok(output);

        }

        [Route("addCategoriaAll")]
        [HttpPost]
        public IActionResult addCategoriaAll()
        {
            var output = _CategoriaServices.addCategoriaAll();
            return Ok(output);

        }

    }
}
