﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Context:Db tabloları ile classları bağlamak
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");
        }

        public DbSet<Product> Products { get; set; }
        //Hangi clasım hangi tabloya karsılık gelir onu yaptık
        public DbSet<Category> Categories { get; set; }

        public DbSet<Customer> Customers { get; set; }
    }
}
