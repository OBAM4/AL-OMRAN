﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace testOmrane
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AlOmranEntities1 : DbContext
    {
        public AlOmranEntities1()
            : base("name=AlOmranEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Categorie> Categories { get; set; }
        public virtual DbSet<Collaborateur> Collaborateurs { get; set; }
        public virtual DbSet<Entite> Entites { get; set; }
        public virtual DbSet<Marque> Marques { get; set; }
        public virtual DbSet<Materiel> Materiels { get; set; }
        public virtual DbSet<Affectation> Affectations { get; set; }
    }
}