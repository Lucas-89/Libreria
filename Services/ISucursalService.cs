using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Libreria.Models;

namespace Libreria.Services
{
    public interface ISucursalService
    {
        void Create(Sucursal obj);
        List<Sucursal> GetAll();
        void Update(Sucursal obj );  
        void Delete(Sucursal obj);
        Sucursal GetById(int id);
    }
}