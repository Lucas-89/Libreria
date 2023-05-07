using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Libreria.Models;

namespace Libreria.ViewModels
{
    public class AutorViewModel
    {
        public List<Autor> Autores {get;set;} = new List<Autor>();
        public string NombreBuscado {get;set;}
    }
}