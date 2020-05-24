using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Person_Registro.Models;

namespace Person_Registro.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Personas> personas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = DBPersons.db");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
