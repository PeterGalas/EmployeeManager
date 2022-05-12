using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OfficeManager.Models
{
    public class OfficeManagerDbContext: DbContext
    {
        public OfficeManagerDbContext(DbContextOptions<OfficeManagerDbContext> options) : base(options)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
