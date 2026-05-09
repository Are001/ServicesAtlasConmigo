using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
       
        [FechaPersonalizada]
        public DateTime fechatRegistro {get; set;}

    }

    public class CategoriaModelInsertInput 
    {
        [Required]
        public string descripcion { get; set; }
        [Required]
        public bool esActivo { get; set; }
        [FechaPersonalizada]
        public string fechatRegistro { get; set; }

    }

    public class CategoriaModelResulInsertOutput
    {
        public int NU_ROW { get; set; }
        public string NB_ALERTA { get; set; }
    }

    public class CategoriaModelResulOutput
    {
        public int NU_ROW { get; set; }
        public string NB_ALERTA { get; set; }
    }
}
