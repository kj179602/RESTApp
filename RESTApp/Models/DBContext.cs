using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace RESTApp.Models
{
    public class DBContext : DbContext
    {
         public DBContext() : base("DBContext") { }

        public DbSet<Product> Products { get; set; }
    }
}