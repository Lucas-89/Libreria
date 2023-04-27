using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Libreria.Utils;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Libreria.Models
{
    public class Libro
    {
        public int Id{get;set;}
        public string Nombre{get;set;}
        public string NombreAutor {get;set;}
        public int AutorId{get;set;} // despues va ser relacion 1- Muchos
       // public virtual Autor Autor {get;set;}
        public TipoCategoria Categoria {get;set;}
        public DateTime FechaPublicacion{get;set;}

        //[Display(Paginas="Cantidad de Paginas")]  No funciona
        public int Paginas{get;set;}
        public bool Tapa{get;set;} //tapa dura = true

    }
}