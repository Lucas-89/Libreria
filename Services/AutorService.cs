using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Libreria.Data;
using Libreria.Models;
using Microsoft.EntityFrameworkCore;

namespace Libreria.Services
{
    public class AutorService : IAutorService
    {
        private readonly AutorContext _context;
        public AutorService(AutorContext context){
            _context = context;
        }
        public void Create(Autor obj)
        {
           _context.Add(obj);
           _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var obj = GetById(id);
            if (obj != null)
            {
                _context.Remove(obj);
                _context.SaveChanges();
            }
            
        }

        public List<Autor> GetAll()
        {
            var query = from autor in _context.Autor select autor;
            return query.ToList();
        }

        public List<Autor> GetAll(string filter)
        {
           var query = from autor in _context.Autor select autor;

            if (!string.IsNullOrEmpty(filter))
            {
                query = query.Where(x => x.Nombre.ToLower().Contains(filter.ToLower()));
            }
            return query.ToList();
        }

        public Autor GetById(int id)
        {
            var autor = _context.Autor
            .Include(l => l.Libros)
            .FirstOrDefault(m => m.Id == id);

        return autor;
        }

        public void Update(Autor obj)
        {
            _context.Update(obj);
            _context.SaveChanges();
        }
    }
}