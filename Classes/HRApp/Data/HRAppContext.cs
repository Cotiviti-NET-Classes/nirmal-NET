#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HRApp.Models;

namespace HRApp.Data
{
    public class HRAppContext : DbContext
    {
        public HRAppContext (DbContextOptions<HRAppContext> options)
            : base(options)
        {
        }

        public DbSet<HRApp.Models.Department> Department { get; set; }

        public DbSet<HRApp.Models.Employee> Employee { get; set; }

        public DbSet<HRApp.Models.Designation> Designation { get; set; }
    }
}
