using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectCare01.Models;

namespace ProjectCare01.Data
{
    public class ApplicationDBContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext>options)
            :base(options)
            {
        }
        public DbSet<Order>Orders { get; set; }

        public DbSet<Product>Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
