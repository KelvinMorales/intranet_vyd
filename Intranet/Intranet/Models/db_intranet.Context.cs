﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Intranet.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class db_intranet_vydEntities : DbContext
    {
        public db_intranet_vydEntities()
            : base("name=db_intranet_vydEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<int_com_historial> int_com_historial { get; set; }
        public virtual DbSet<int_directorios> int_directorios { get; set; }
        public virtual DbSet<int_empresas> int_empresas { get; set; }
        public virtual DbSet<int_eve_comentarios> int_eve_comentarios { get; set; }
        public virtual DbSet<int_eve_detalle> int_eve_detalle { get; set; }
        public virtual DbSet<int_eventos> int_eventos { get; set; }
        public virtual DbSet<int_responsables> int_responsables { get; set; }
        public virtual DbSet<int_solicitudes> int_solicitudes { get; set; }
        public virtual DbSet<int_sucursales> int_sucursales { get; set; }
        public virtual DbSet<int_tipo_solicitud> int_tipo_solicitud { get; set; }
        public virtual DbSet<int_usu_categorias> int_usu_categorias { get; set; }
        public virtual DbSet<int_usuarios> int_usuarios { get; set; }
    }
}