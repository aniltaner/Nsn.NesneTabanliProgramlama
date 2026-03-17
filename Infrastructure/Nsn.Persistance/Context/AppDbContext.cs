using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nsn.Domain.Entities;

namespace Nsn.Persistance.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext ()
        {

        }
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        DbSet<Category> Categories { get; set; }

        DbSet<Detail> Details { get; set; }

        DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
    
