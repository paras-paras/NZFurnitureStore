﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NZFurnitureStore.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NZFurnitureEntities : DbContext
    {
        public NZFurnitureEntities()
            : base("name=NZFurnitureEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Labour> Labours { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<QuerySection> QuerySections { get; set; }
        public virtual DbSet<Salary> Salaries { get; set; }
    }
}
