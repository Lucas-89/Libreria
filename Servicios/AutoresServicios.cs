using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibreriaDigital.Modelos;


namespace LibreriaDigital.Servicios

{   public interface IAutorServicio{
        List<Autor> MostrarTodos();
        void Agregar (Autor autornuevo);
        void Editar (Autor autored);
        void Eliminar (Autor autorborrado);
    }

    public class AutoresServicios : IAutorServicio
    {
        private List<Autor> ListaAutores;

        public AutoresServicios(){
            ListaAutores= new List<Autor>()
            {
                new Autor(){Id=1, Nombre="Antoine de Saint-Exupéry", Nacionalidad="Francia",Contemporaneo=false},
                new Autor(){Id=2, Nombre="Stephen King", Nacionalidad="Estados Unidos",Contemporaneo=true},
                new Autor(){Id=3, Nombre="George Orwell", Nacionalidad="Inglaterra",Contemporaneo=false},
                new Autor(){Id=4, Nombre="Julio Verne", Nacionalidad="Fracia",Contemporaneo=false},
                new Autor(){Id=5, Nombre="Ray Bradbury", Nacionalidad="Estados Unidos",Contemporaneo=false},
                new Autor(){Id=6, Nombre="Edgar Allan Poe", Nacionalidad="Estados Unidos",Contemporaneo=false},
                new Autor(){Id=7, Nombre="Eckhart Tolle", Nacionalidad="Alemania",Contemporaneo=true},
                new Autor(){Id=8, Nombre="J. K. Rowling", Nacionalidad="Inglaterra",Contemporaneo=true},
                new Autor(){Id=9, Nombre="Josephine Tey", Nacionalidad="Inglaterra",Contemporaneo=false}

            };
        }
        public List<Autor> MostrarTodos(){
            return ListaAutores;
        }
        public void Agregar(Autor autornuevo){
            ListaAutores.Add(autornuevo);
        }
        public void Editar (Autor autored){
            var autororiginal = ListaAutores.Where(x=>x.Id==autored.Id).First();
            ListaAutores.Remove(autororiginal);
            ListaAutores.Add(autored);
        }
        public void Eliminar(Autor autorborrado){
            var autoraeliminar= ListaAutores.Where(x=>x.Id==autorborrado.Id).First();
            ListaAutores.Remove(autoraeliminar);
        }
    }
}