﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDatos.GestionUsuario
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GestionContainer : DbContext
    {
        public GestionContainer()
            : base("name=GestionContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<FuncionDeAcceso> FuncionesDeAcceso { get; set; }
        public DbSet<FuncionAsignada> FuncionesAsignadas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}