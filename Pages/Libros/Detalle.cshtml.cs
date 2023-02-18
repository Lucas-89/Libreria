using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LibreriaDigital.Modelos;
using LibreriaDigital.Pages.Libros;
using LibreriaDigital.Servicios;

namespace LibreriaDigital.Pages.Libros
{
    public class DetalleModel : PageModel
    {
        [BindProperty]
        public Libro LibroDet{get;set;}

        private ILibroServicio _libserv;

        public DetalleModel(ILibroServicio libSvr){
            _libserv= libSvr;
        }
        public void OnGet(int Id)
        {
            var detalle= _libserv.MostrarTodos();
            LibroDet= detalle.Where(x=>x.Id==Id).First();
        }
    }
}
