using AtlasLibraries.DBComandos;
using AtlasLibraries.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtlasLibraries.Services
{
    public class CategoriaServices
    {
        public CategoriaDBCommand categoriaDBCommand;
        public CategoriaServices(CategoriaDBCommand CategoriasDBCommand ) { 
            this.categoriaDBCommand = CategoriasDBCommand;
        }

        //como el                                lo que resive del input
        public List<CategoriaModelOutput> AllCategorias()
        {
            var AllCategorias = categoriaDBCommand.sa_categorias("<root><accion>C</accion><ST_FECHAREGISTRO></ST_FECHAREGISTRO></root>");
            string json = JsonConvert.SerializeObject(AllCategorias);
            List<CategoriaModelOutput> listaCategoria = JsonConvert.DeserializeObject<List<CategoriaModelOutput>>(json);

            return listaCategoria;

        }

        public List<CategoriaModelInsertOutput> addCategoria()
        {
            var AddCategoria = categoriaDBCommand.sa_categorias("<root><accion>I</accion><NB_DESCRIPCION>Monitores</NB_DESCRIPCION><NB_ESACTIVO>1</NB_ESACTIVO><ST_TELEFONO>23424578</ST_TELEFONO><NB_URLFOTO>FOTO</NB_URLFOTO><ST_FECHAREGISTRO>20260506</ST_FECHAREGISTRO></root>");
            string json = JsonConvert.SerializeObject(AddCategoria);
            List<CategoriaModelInsertOutput> listaCategoria = JsonConvert.DeserializeObject<List<CategoriaModelInsertOutput>>(json);

            return listaCategoria;
        }

        public List<CategoriaModelOutput> addCategoriaAll()
        {
            var AddCategoriALL = categoriaDBCommand.sa_categorias("<root><accion>I</accion><NB_DESCRIPCION>Mouse</NB_DESCRIPCION><NB_ESACTIVO>1</NB_ESACTIVO><ST_TELEFONO>23424578</ST_TELEFONO><NB_URLFOTO>FOTO</NB_URLFOTO><ST_FECHAREGISTRO>20260506</ST_FECHAREGISTRO></root>");
            string json = JsonConvert.SerializeObject(AddCategoriALL);
            List<CategoriaModelOutput> listaCategoriaAll = JsonConvert.DeserializeObject<List<CategoriaModelOutput>>(json);

            return listaCategoriaAll;

        }
    }
}
