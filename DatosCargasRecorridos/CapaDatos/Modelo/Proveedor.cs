//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDatos.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Proveedor
    {
        public Proveedor()
        {
            this.Viaje = new HashSet<Viaje>();
        }
    
        public int Id { get; set; }
        public string CodigoProveedor { get; set; }
        public string NombreEmpresaProveedor { get; set; }
        public string Nombre1Encargado { get; set; }
        public string Nombre2Encargado { get; set; }
        public string Apellido1Encargado { get; set; }
        public string Apellido2Encargado { get; set; }
        public string Cargo { get; set; }
        public string DireccionEmpresa { get; set; }
        public string CelularProveedor { get; set; }
        public string Comentario { get; set; }
    
        public virtual ICollection<Viaje> Viaje { get; set; }
    }
}
