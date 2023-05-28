using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Libreria.Models;

namespace Libreria.Services
{
    public interface IAutorService
    {
        void Create(Autor obj);
        List<Autor>GetAll();
        List<Autor>GetAll(string filter);
        void Update(Autor obj);
        void Delete(int id);
        Autor? GetById(int id);
    }
}