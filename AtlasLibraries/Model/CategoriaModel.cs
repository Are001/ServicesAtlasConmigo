using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtlasLibraries.Model
{
    public class CategoriaModelOutput
    {
        public int idCategoria { get; set; }
        public string descripcion { get; set; }
        public bool esActivo { get; set; }
        public DateTime fechatRegistro {get; set;}

    }

    public class CategoriaModelInsertOutput
    {
        public int NU_ROW { get; set; }
        public string NB_ALERTA { get; set; }
    }
}
