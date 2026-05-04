using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtlasLibraries.Interfaces.Data
{
    internal interface IUsuarios
    {
        DataTable obtenerUsuarios(string usuarios);
    }
}
