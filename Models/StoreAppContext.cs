//using Microsoft.EntityFrameworkCore;
using Store.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace StoreApp.Models
{
    public class StoreAppContext : DbContext
    {
        // public StoreAppContext() : base("(localdb)\\MSSQLLocalDB;Initial Catalog = GlushkoDB; Integrated Security = True");
        // string connectionString = "(localdb)\\MSSQLLocalDB;Initial Catalog = GlushkoDB; Integrated Security = True";
        /*public StoreAppContext() : base ("DbConnectionString")
        {

        }*/
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer("@Server=(localdb)\\MSSQLLocalDB;Initial Catalog = GlushkoDB; Integrated Security = True;");
        }
        public Microsoft.EntityFrameworkCore.DbSet<Arrival> Arrivals { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Otdel> otdels { get; set; }
        public System.Data.Entity.DbSet<Sale> sales { get; set; }
        public System.Data.Entity.DbSet<Product> Products { get; set; }
        public System.Data.Entity.DbSet<User> users { get; set; }

       // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      //  {
       //     optionsBuilder.UseSqlServer(@"Server=(localdb)\\MSSQLLocalDB;Database=DbGlushko;Trusted_Connection=True;");
       // }
    }
    
}
