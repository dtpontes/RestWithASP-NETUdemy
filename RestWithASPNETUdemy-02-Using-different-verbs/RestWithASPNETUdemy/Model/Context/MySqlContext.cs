using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Model.Context
{
    public class MySqlContext : DbContext
    {
        protected MySqlContext()
        {
        }

        protected MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {
        }

        public DbSet<Person> Person { get; set; }
    }
}
