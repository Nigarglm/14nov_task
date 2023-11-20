using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _14nov_task.Models;
using Microsoft.EntityFrameworkCore;

namespace _14nov_task.DAL
{
    internal class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=DESKTOP-NK9HMU9\\MSSQLSERVER01;database=14NovTask;trusted_connection=true;integrated security=true");

        }

    }
}
