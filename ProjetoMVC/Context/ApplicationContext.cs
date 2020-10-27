using Microsoft.EntityFrameworkCore;
using ProjetoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoMVC.Context
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer("Server=DESKTOP-65I5PJ5\\SQLEXPRESS;Database=Mov;Trusted_Connection=True;");
    }
}
