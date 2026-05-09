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
        public List<CategoriaModelResulInsertOutput> AllUsuarios()
        {
            var AllUsers = _UsuarioDBCommand.sa_usuarios("<root><accion>C</accion><NB_EMAIL></NB_EMAIL></root>");
            string json = JsonConvert.SerializeObject(AllUsers);
            
            List<CategoriaModelResulInsertOutput> listaPersonas = JsonConvert.DeserializeObject<List<CategoriaModelResulInsertOutput>>(json);

            return listaPersonas;
        }

        
        public List<UsuariosBDModelOutput> AddUsuarios()
        {
            var AddUsers = _UsuarioDBCommand.sa_usuarios("<root><accion>I</accion><NB_NOMBRE>Juana</NB_NOMBRE><NB_EMAIL>juana@hotmail.com</NB_EMAIL><ST_TELEFONO>23424578</ST_TELEFONO><NB_URLFOTO>FOTO</NB_URLFOTO><NB_NOMBREFOTO>FOTO20</NB_NOMBREFOTO><NB_CLAVE>FOTO</NB_CLAVE><ST_ESACTIVO>1</ST_ESACTIVO><FH_REGISTRO>2026-04-20</FH_REGISTRO></root>");
            string json = JsonConvert.SerializeObject(AddUsers);

            List<UsuariosBDModelOutput> listaUsuarios = JsonConvert.DeserializeObject<List<UsuariosBDModelOutput>>(json);

            return listaUsuarios;
        }
    }
}
