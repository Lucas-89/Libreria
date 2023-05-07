using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Libreria.Models;


namespace Libreria.ViewModels
{
    public class AutorDetailViewModel
    {
        public int Id{get;set;}
        public string Nombre{get;set;}
        public string Nacionalidad{get;set;}
        public List<Libro> Libros{get;set;} 
    }
}