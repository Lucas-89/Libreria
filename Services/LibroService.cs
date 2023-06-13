using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Libreria.Data;
using Libreria.Models;
using Microsoft.EntityFrameworkCore;

namespace Libreria.Services;

public class LibroService : ILibroService
{
    private readonly AutorContext _context;
    public LibroService(AutorContext context){
        _context = context;
    }
    public void Create(Libro obj)
    {
        _context.Add(obj);
        _context.SaveChanges();
    }

    public void Delete(Libro obj)
    {
        _context.Remove(obj);
        _context.SaveChanges();
    }

    public List<Libro> GetAll()
    {
        return _context.Libro.Include(l => l.Autor).ToList();
    }
    public List<Libro> GetAll(string filter)
    {
        var query = from libro in _context.Libro select libro;
        if (!string.IsNullOrEmpty(filter))
        {
            query = query.Where(x => x.Titulo.ToLower().Contains(filter.ToLower()));
        }
        return query.ToList();
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
        _context.Update(obj);
        _context.SaveChanges();
        
    }
}