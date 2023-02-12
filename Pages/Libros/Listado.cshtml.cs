using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LibreriaDigital.Servicios;
using LibreriaDigital.Pages.Libros; //modifique esto .Libros
using LibreriaDigital.Modelos;

namespace LibreriaDigital.Pages.Libros
{
    public class ListadoModel : PageModel
    {
        [BindProperty]
        public List<Libro> ListaStock{get;set;}
        private ILibroServicio _libroServicio;
        public ListadoModel(ILibroServicio libsrv){
            _libroServicio = libsrv; // tengo que saber que tiene esto adentro
        }
        public void OnGet()
        {
           ListaStock=_libroServicio.MostrarTodos();
        }
    }
}
