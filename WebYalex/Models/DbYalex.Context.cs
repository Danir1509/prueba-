﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebYalex.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbYalex : DbContext
    {
        public DbYalex()
            : base("name=DbYalex")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<alquileres> alquileres { get; set; }
        public virtual DbSet<clientes> clientes { get; set; }
        public virtual DbSet<contratos> contratos { get; set; }
        public virtual DbSet<empleado> empleado { get; set; }
        public virtual DbSet<entrega> entrega { get; set; }
        public virtual DbSet<reserva> reserva { get; set; }
        public virtual DbSet<vehiculo> vehiculo { get; set; }
    }
}
