﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    //using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Data.Entity.Core.Objects; //Agregar
    using System.Linq;

    public partial class Model1Container : DbContext
    {
        public Model1Container()
            : base("name=Model1Container")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<TipoDeVehiculo> TipoDeVehiculos { get; set; }
        public DbSet<Viaje> Viajes { get; set; }
        public DbSet<TipoDeViaje> TipoDeViajes { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Chofer> Choferes { get; set; }
        public DbSet<VehiculoViaje> VehiculoViajes { get; set; }
        public DbSet<ViajeChofer> ViajeChoferes { get; set; }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<ModeloDelVehiculo> ModeloDeLosVehiculos { get; set; }
        public DbSet<MarcaVehiculo> MarcaVehiculos { get; set; }
    
        public virtual ObjectResult<usp_BucarViaje_Result> usp_BucarViaje(string codv)
        {
            var codvParameter = codv != null ?
                new ObjectParameter("codv", codv) :
                new ObjectParameter("codv", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_BucarViaje_Result>("usp_BucarViaje", codvParameter);
        }
    
        public virtual ObjectResult<usp_DetalleViaje_Result> usp_DetalleViaje(string codv)
        {
            var codvParameter = codv != null ?
                new ObjectParameter("codv", codv) :
                new ObjectParameter("codv", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_DetalleViaje_Result>("usp_DetalleViaje", codvParameter);
        }
    
        public virtual ObjectResult<usp_MostrarChofer_Result> usp_MostrarChofer(string cedula)
        {
            var cedulaParameter = cedula != null ?
                new ObjectParameter("cedula", cedula) :
                new ObjectParameter("cedula", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_MostrarChofer_Result>("usp_MostrarChofer", cedulaParameter);
        }
    
        public virtual ObjectResult<usp_Proveedor_Result> usp_Proveedor(string codigo)
        {
            var codigoParameter = codigo != null ?
                new ObjectParameter("codigo", codigo) :
                new ObjectParameter("codigo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_Proveedor_Result>("usp_Proveedor", codigoParameter);
        }
    
        public virtual ObjectResult<usp_Vehiculo_Result> usp_Vehiculo(string placa)
        {
            var placaParameter = placa != null ?
                new ObjectParameter("placa", placa) :
                new ObjectParameter("placa", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_Vehiculo_Result>("usp_Vehiculo", placaParameter);
        }
    }
}
