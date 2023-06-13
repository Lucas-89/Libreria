using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Libreria.Data;
using Libreria.Models;

namespace Libreria.Services
{
    public class SucursalService : ISucursalService
    {
        private readonly AutorContext _context;

        public SucursalService(AutorContext context){
            _context = context;
        }
        public void Create(Sucursal obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Sucursal obj)
        {
            throw new NotImplementedException();
        }

        public List<Sucursal> GetAll()
        {
            throw new NotImplementedException();
        }

        public Sucursal GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Sucursal obj)
        {
            throw new NotImplementedException();
        }
    }
}