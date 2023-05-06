using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Libreria.Models;

namespace Libreria.Data
{
    public class LibroContext : DbContext
    {
        public LibroContext (DbContextOptions<LibroContext> options)
            : base(options)
        {
        }

        public DbSet<Libreria.Models.Libro> Libro { get; set; } = default!;

        public DbSet<Libreria.Models.Autor> Autor { get; set; } = default!;

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autor>()
            .HasMany(p=>p.Libros)
            .WithOne(p=>p.Autor)
            .HasForeignKey(p=>p.AutorId); // si no funciona, probar con p.Id (de Libros)
        }
        
    }
}
