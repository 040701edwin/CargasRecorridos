using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Modelo
{
    public partial class Proveedor
    {
        public string NombreCompleto { get { return Apellido1Encargado + " " + Nombre1Encargado; } }
    }
}
