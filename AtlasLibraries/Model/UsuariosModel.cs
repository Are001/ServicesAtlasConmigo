using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtlasLibraries.Model
{
    public class UsuariosBDModelOutput
    {
        public int IdUsuario{  get; set; }
        public string nombre { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public string urlFoto { get; set; }
        public string nombreFoto { get; set; }
        public string Clave { get; set; }
        public string EsActivo { get; set;}
        public DateTime FechaREGISTRO { get; set; }
    }
}
