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
    
    public partial class ModeloDelVehiculo
    {
        public ModeloDelVehiculo()
        {
            this.Vehiculo = new HashSet<Vehiculo>();
        }
    
        public int Id { get; set; }
        public string Modelo { get; set; }
        public int MarcaVehiculoId { get; set; }
    
        public virtual ICollection<Vehiculo> Vehiculo { get; set; }
        public virtual MarcaVehiculo MarcaVehiculo { get; set; }
    }
}
