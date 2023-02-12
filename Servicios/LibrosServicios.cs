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
                new Libro(){Id=1,Nombre="El Principito", Genero="Fantasia", Formato="Normal", CantHojas=12, TapaDura=true, FechaPublicacion=new DateTime(1986,10,16),Calificacion=2},
                new Libro(){Id=2,Nombre="IT", Genero="Terror", Formato="De Bolsillo", CantHojas=300, TapaDura=false, FechaPublicacion=new DateTime(2000,12,20),Calificacion=3},
                new Libro(){Id=3,Nombre="Don Quijote", Genero="Novela",  Formato="Extendido", CantHojas=221, TapaDura=true, FechaPublicacion=new DateTime(1977,09,02),Calificacion=1}
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