using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibreriaDigital.Modelos;

namespace LibreriaDigital.Servicios
{
    public interface ILibroServicio{
        List<Libro> MostrarTodos();
        void Agregar (Libro libronuevo);
        void Editar (Libro libroed);
        void Eliminar (Libro libroborrado);
    }

    public class LibrosServicio : ILibroServicio
    {
        private List<Libro> ListaLibros;
        // este constructor LibrosServicios se usa para inicializar la lista ListaLibros con valores
        public LibrosServicio(){
            ListaLibros= new List<Libro>()
            {
                new Libro(){Id=1,Nombre="El Principito", Genero="Fantasia", Formato="Normal", CantHojas=120, TapaDura=true, FechaPublicacion=1943,Calificacion=2},
                new Libro(){Id=2,Nombre="IT", Genero="Terror", Formato="De Bolsillo", CantHojas=300, TapaDura=false, FechaPublicacion=1986,Calificacion=3},
                new Libro(){Id=3,Nombre="Don Quijote", Genero="Parodia",  Formato="Extendido", CantHojas=462, TapaDura=true, FechaPublicacion=1605,Calificacion=1},
                new Libro(){Id=4,Nombre="1984", Genero="Ciencia Ficcion",  Formato="Normal", CantHojas=352, TapaDura=true, FechaPublicacion=1949,Calificacion=1},
                new Libro(){Id=5,Nombre="Como Ganar Amigos e Influir Sobre las Personas", Genero="Autoayuda",  Formato="Extendido", CantHojas=318, TapaDura=true, FechaPublicacion=1936,Calificacion=1},
                new Libro(){Id=6,Nombre="Cronicas Marcianas", Genero="Ciencia Ficcion",  Formato="Extendido", CantHojas=268, TapaDura=true, FechaPublicacion=1950,Calificacion=1},
                new Libro(){Id=7,Nombre="El Gato Negro", Genero="Terror",  Formato="Normal", CantHojas=136, TapaDura=true, FechaPublicacion=1809,Calificacion=1},
                new Libro(){Id=8,Nombre="El Poder del Ahora", Genero="Autoayuda",  Formato="De Bolsillo", CantHojas=220, TapaDura=true, FechaPublicacion=1997,Calificacion=1},
                new Libro(){Id=9,Nombre="Harry Potter y la Piedra Filosofal", Genero="Fantasia",  Formato="Extendido", CantHojas=256, TapaDura=true, FechaPublicacion=1997,Calificacion=1},
                new Libro(){Id=10,Nombre="La Hija Del Tiempo", Genero="Policial",  Formato="De Bolsillo", CantHojas=260, TapaDura=true, FechaPublicacion=1951,Calificacion=1},
                new Libro(){Id=11,Nombre="Los Cuatro Acuerdos", Genero="Autoayuda",  Formato="Extendido", CantHojas=160, TapaDura=true, FechaPublicacion=1998,Calificacion=1},
                new Libro(){Id=12,Nombre="Viaje al Centro de la Tierra", Genero="Ciencia Ficcion",  Formato="De Bolsillo", CantHojas=360, TapaDura=true, FechaPublicacion=1864,Calificacion=1}

            };
        }
        public List<Libro> MostrarTodos(){
            return ListaLibros;
        }
        public void Agregar (Libro libronuevo){
            ListaLibros.Add(libronuevo);
        }
        public void Editar (Libro libroed){
            var librooriginal= ListaLibros.Where(x=>x.Id==libroed.Id).First();
            ListaLibros.Remove(librooriginal);
            ListaLibros.Add(libroed);
        }
        public void Eliminar (Libro libroborrado){
            var libroaeliminar=ListaLibros.Where(x=>x.Id==libroborrado.Id).First();
            ListaLibros.Remove(libroaeliminar);  
        }
    }
}