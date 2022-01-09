using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PizaaOrdering.Models;
using SLE_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOrdering.Controllers.Models
{
    public class AppDBContext : IdentityDbContext
    {
        private readonly DbContextOptions _options;
        public AppDBContext(DbContextOptions options): base(options)
        {
            _options = options; 
        }
        public DbSet<OrderPizza> Ordertabel { get; set; }
      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
