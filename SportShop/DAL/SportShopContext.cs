using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using SportShop.Views.Entities;

namespace SportShop.DAL
{
    public class SportShopContext : DbContext
    {

        //lista inicjalizacyjna konstruktora
        public SportShopContext() : base("SportShopContext")
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }


        //metoda usuwająca liczbe mnoga z Customers, Products, Categories. Wyswietlona bedzie l. poj.
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}