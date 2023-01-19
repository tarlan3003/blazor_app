using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace eilink_webapp.Data
{
    public class SqlDBContext : DbContext 
    {
        public SqlDBContext(DbContextOptions<SqlDBContext> options)
           : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
