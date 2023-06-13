using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Libreria.Data;
using Libreria.Models;
using Microsoft.EntityFrameworkCore;

namespace Libreria.Services
{
    public class LibroService : ILibroService
    {
        private readonly AutorContext _context;
        public LibroService(AutorContext context){
            _context = context;
        }

        public void Create(Libro obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Libro obj)
        {
            throw new NotImplementedException();
        }

        public List<Libro> GetAll()
        {
           return _context.Libro.Include(l => l.Autor).ToList();
        }

        public Libro? GetById(int id)
        {
            var libro = _context.Libro
                .Include(l => l.Autor)
                .FirstOrDefault(m => m.Id == id);
                return libro;
        }

        public void Update(Libro obj)
        {
            throw new NotImplementedException();
        }
    }
}