using AtlasLibraries.DBComandos;
using AtlasLibraries.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Results;

namespace AtlasLibraries.Services
{
    public class CategoriaServices
    {
        public CategoriaDBCommand categoriaDBCommand;
        public CategoriaServices(CategoriaDBCommand CategoriasDBCommand ) { 
            this.categoriaDBCommand = CategoriasDBCommand;
        }

        //como el                                lo que resive del input
        public object AllCategorias()
        //public List<object> AllCategorias()
        { 

            var AllCategorias = categoriaDBCommand.sa_categorias("<root><accion>C</accion></root>");
            string json = JsonConvert.SerializeObject(AllCategorias);
            var resultado = JsonConvert.DeserializeObject(json);
            
   
            return resultado;



        }

        //lo que va despues del public es el tipo de dato que retornas y lo que va entre parentesis es lo que resives.
        public List<CategoriaModelResulInsertOutput> addCategoria(CategoriaModelInsertInput input)
        {
            var AddCategoria = categoriaDBCommand.sa_categorias($"<root><accion>I</accion><NB_DESCRIPCION>{input.descripcion}</NB_DESCRIPCION><ST_ESACTIVO>{input.esActivo}</ST_ESACTIVO><FH_FECHAREGISTRO>{input.fechatRegistro}</FH_FECHAREGISTRO></root>");
            string json = JsonConvert.SerializeObject(AddCategoria);
            List<CategoriaModelResulInsertOutput> listaCategoria = JsonConvert.DeserializeObject<List<CategoriaModelResulInsertOutput>>(json);

            return listaCategoria;
        }

  
    }
}
