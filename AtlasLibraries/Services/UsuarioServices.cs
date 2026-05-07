using AtlasLibraries.DBComandos;
using AtlasLibraries.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;



namespace AtlasLibraries.Services
{
    public class UsuarioServices
    {
        public UsuarioDBCommand _UsuarioDBCommand;

        public UsuarioServices( UsuarioDBCommand UseDBCommand) { 
            this._UsuarioDBCommand = UseDBCommand;
        }

        public PersonalModelOutput CalcularAnios(PersonaModelInput input) {

            //_UsuarioDBCommand.sa_usuarios("<root><accion>C</accion><NB_EMAIL></NB_EMAIL></root>");

            DateTime Day = DateTime.Today;
            DateTime anio = DateTime.Parse(input.FechaNacimiento);
            var age = Day.Year - anio.Year;


            var mensaje = "Hola mi nombre es " + input.Nombre + " tengo " + age;
            //return Ok(mensaje);

            var objPersona = new PersonalModelOutput();
            objPersona.resultado = $"mensaje para el modelo de salida: {mensaje}"; /*asignamos a objPersona lo que tiene el mensaje*/

            return objPersona;
        }

        //Este es mi salida el tipo de dato que regresa el metodo
        public List<CategoriaModelInsertOutput> AllUsuarios()
        {
            var AllUsers = _UsuarioDBCommand.sa_usuarios("<root><accion>C</accion><NB_EMAIL></NB_EMAIL></root>");
            string json = JsonConvert.SerializeObject(AllUsers);
            
            List<CategoriaModelInsertOutput> listaPersonas = JsonConvert.DeserializeObject<List<CategoriaModelInsertOutput>>(json);

            return listaPersonas;
        }
    }
}
