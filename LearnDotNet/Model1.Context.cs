﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LearnDotNet
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class AdventureWorks2012Entities1 : DbContext
    {
        public AdventureWorks2012Entities1()
            : base("name=AdventureWorks2012Entities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<GetAllPersons_Result> GetAllPersons()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllPersons_Result>("GetAllPersons");
        }
    }
}
