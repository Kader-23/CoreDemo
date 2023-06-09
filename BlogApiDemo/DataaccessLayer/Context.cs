using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApiDemo.DataaccessLayer
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-OI6LU3R\\MSSQLSERVER01; database=CoreBlogApiDb; " +
                "integrated security=true;");

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
