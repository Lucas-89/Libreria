using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibreriaDigital.Modelos
{
    public class Autor
    {
        [Required]
        public int Id{get;set;}
        [Required]
        public string Nombre{get;set;}

        public string Nacionalidad{get;set;}

        public bool Contemporaneo{get;set;}  // vivo o muerto
        public List<Libro> Libros{get;set;}
    }
}