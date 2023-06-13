using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Libreria.Models;
using Libreria.Utils;

namespace Libreria.ViewModels
{
    public class LibroCreateViewModel
    {
        public int Id{get;set;}
        public string Titulo {get;set;}
        public TipoGenero Genero {get;set;}
        public int Precio{get;set;}
        public int Stock{get;set;}
        public int AutorId{get;set;}
        //public List<Autor> autores{get;set;}
    }
}