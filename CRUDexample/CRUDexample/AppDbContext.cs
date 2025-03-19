using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CRUDexample
{
    class AppDbContext : DbContext //by extending this class AppDbContext can run queries in database with DB connection
    {
        public DbSet<Item> Items { get; set; } // connecting with Items table in DB with Item.cs code using DbSet

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //DbContextOptionsBuilder is used to connect MSSQL as a DB provider with a connection string
        //override to give our connection string
        //UseSqlServer --> MSSQL
        {
            optionsBuilder.UseSqlServer
                ("Data Source=DESKTOP-MEC9K3Q;Initial Catalog=Product;Integrated Security=True;Trust Server Certificate=True");

        }
    }
}
