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
    }
}
