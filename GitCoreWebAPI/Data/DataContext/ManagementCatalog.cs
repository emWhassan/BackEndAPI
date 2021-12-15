using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GitCoreWebAPI.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace GitCoreWebAPI.Data.DataContext
{
    public class ManagementCatalogDBContext:DbContext
    {
        public ManagementCatalogDBContext(DbContextOptions<ManagementCatalogDBContext> options):base(options)
        {

        }
        public DbSet<Department> Departments { get; set; }
    }
}
