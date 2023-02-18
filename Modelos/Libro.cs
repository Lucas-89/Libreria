using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LibreriaDigital.Modelos
{
    public class Libro
    {
        [Required]
        public int Id{get;set;}
        [Required]
        public string Nombre{get;set;}
        public string Genero{get;set;}
       
        public string Formato{get;set;} // de bolsillo o normal
        
        public int CantHojas{get;set;}
        public bool TapaDura{get;set;}
        public int FechaPublicacion {get;set;}
        public int Calificacion{get;set;} //esto es un checkbox de 4 opciones

       // public Autor AutorLibro{get;set;}
    }
}