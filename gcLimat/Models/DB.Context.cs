﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace gcLimat.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class gdlimatEntities : DbContext
    {
        public gdlimatEntities()
            : base("name=gdlimatEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_CLIENTES> tbl_CLIENTES { get; set; }
        public virtual DbSet<tbl_EQUIPO> tbl_EQUIPO { get; set; }
        public virtual DbSet<tbl_PRUEBACROMATOGRAFICA> tbl_PRUEBACROMATOGRAFICA { get; set; }
        public virtual DbSet<tbl_PRUEBAELECTRICA> tbl_PRUEBAELECTRICA { get; set; }
        public virtual DbSet<tbl_PRUEBAFISICA> tbl_PRUEBAFISICA { get; set; }
        public virtual DbSet<tbl_PRUEBAQUIMICA> tbl_PRUEBAQUIMICA { get; set; }
        public virtual DbSet<tbl_REPORTE> tbl_REPORTE { get; set; }
        public virtual DbSet<tbl_CONTROLDEUSUARIOS> tbl_CONTROLDEUSUARIOS { get; set; }
        public virtual DbSet<tbl_UNIDADMEDIDA> tbl_UNIDADMEDIDA { get; set; }
    }
}
