using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Libreria.Models;

namespace Libreria.ViewModels
{
    public class LibroCreateViewModel
    {
        public int Id{get;set;}
        public string Titulo {get;set;}
        public string Genero {get;set;}
        public int Precio{get;set;}
        public int AutorId{get;set;}
        public List<Autor> autores{get;set;}
    }
}