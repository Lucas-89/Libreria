using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Libreria.Models;

namespace Libreria.Services
{
    public interface ILibroService
    {
        void Create(Libro obj);
        List<Libro>GetAll();
        List<Libro>GetAll(string filter);
        void Update(Libro obj); 
        void Delete(Libro obj);
        Libro? GetById(int id); //esto es el detalle?
    }
}