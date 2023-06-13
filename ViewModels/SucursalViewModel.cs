using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Libreria.Models;

namespace Libreria.ViewModels
{
    public class SucursalViewModel
    {
        public List<Sucursal> Sucursales {get; set;} =new();
        public string NombreFiltrado{get;set;} 
    }
}