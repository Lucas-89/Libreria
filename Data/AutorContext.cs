using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Libreria.Models;

namespace Libreria.Data
{
    public class AutorContext : DbContext
    {
        public AutorContext (DbContextOptions<AutorContext> options)
            : base(options)
        {
        }

        public DbSet<Libreria.Models.Autor> Autor { get; set; } = default!;

        public DbSet<Libreria.Models.Libro> Libro { get; set; } = default!;

        public DbSet<Libreria.Models.Sucursal> Sucursal { get; set; } = default!;
    }
}
