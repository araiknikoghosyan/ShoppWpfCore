using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Shopp_App_.NetCore.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shopp_App_.NetCore.Context
{
    public class DataContext : DbContext
    {
       public  DbSet<Store> Stores { get; set; }
        public  DbSet<Employes> Employes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLlocaldb; Database=shopDBapp");
        }
    }
}
