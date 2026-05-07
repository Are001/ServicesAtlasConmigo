using AtlasLibraries.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtlasLibraries.Services
{
    public class EjemploServices
    {
        public EjemploModelOutput CalcularAtributos(EjemploModelOutput output)
        {
            //declaramos un  objeto
            EjemploModelOutput salidaAuto = new EjemploModelOutput();
            salidaAuto.NumeroPuertas = 4;

            //return Ok(output);
            return new EjemploModelOutput();
        }
    }
}
