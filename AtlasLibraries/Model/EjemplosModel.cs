using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtlasLibraries.Model
{
    public class EjemplosModel
    {
        //ejercicio 1 carros
        [Required]
        public int Modelo { get; set; }
        public string Color { get; set; }
        public string Marca { get; set; }
        public string TipoMotor { get; set; }
    }
}
