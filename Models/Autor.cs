using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Libreria.Models
{
    public class Autor
    {
        public int Id{get;set;}
        public string Nombre{get;set;}
        public string Nacionalidad{get;set;}
        public bool Contemporaneo{get;set;}
        public virtual List<Libro> Libros{get;set;}

        public static explicit operator Autor(List<Autor> v)
        {
            throw new NotImplementedException();
        }
    }
}