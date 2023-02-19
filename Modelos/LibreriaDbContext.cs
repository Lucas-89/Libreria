using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LibreriaDigital.Modelos
{
    public class LibreriaDbContext : DbContext
    {
        public LibreriaDbContext(DbContextOptions<LibreriaDbContext> options): base(options){

        }
        public DbSet<Autor> Autores{get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder){

        }
    }
}