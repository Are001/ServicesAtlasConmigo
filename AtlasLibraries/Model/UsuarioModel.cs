using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtlasLibraries.Model
{
    public class UsuarioModelInput
    {
        [Required]
        public string Nombre { get; set; }
        [Required]
        [EmailAddress]
        public string CorreoElectronico { get; set; }
        public bool Estatus { get; set; }
        public int Edad { get; set; }
    }

    public class UsuarioModelOutput
    {
        //modelo de salida.
        public UsuarioModelInput TodoElModelo { get; set; }

    } 

    public class PersonaModelInput
    {
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string ApellidoPaterno { get; set; }
        [Required]
        public string ApellidoMaterno { get; set; }

        [Required(ErrorMessage="La fecha no puede quedar vacia.")]
        [FechaPersonalizada]
        //[DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public string FechaNacimiento { get; set; }
    }

    public class PersonalModelOutput
    {
        public string resultado {  get; set; }
    }
    
    }
