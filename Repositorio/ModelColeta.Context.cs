﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Repositorio
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbAppEntities : DbContext
    {
        public dbAppEntities()
            : base("name=dbAppEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Coleta> Coleta { get; set; }
        public virtual DbSet<Lista> Lista { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<Marcas> Marcas { get; set; }
        public virtual DbSet<Mercados> Mercados { get; set; }
        public virtual DbSet<Produtos> Produtos { get; set; }
        public virtual DbSet<ProdutosColeta> ProdutosColeta { get; set; }
        public virtual DbSet<ProdutosLista> ProdutosLista { get; set; }
        public virtual DbSet<Setores> Setores { get; set; }
        public virtual DbSet<TipoColeta> TipoColeta { get; set; }
    }
}
