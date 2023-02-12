using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LibreriaDigital.Servicios;
using LibreriaDigital.Pages.Libros;
using LibreriaDigital.Modelos;

namespace LibreriaDigital.Pages.Libros
{
    public class EditarModel : PageModel
    {
        [BindProperty]
        public Libro LibroEd{get;set;}

        private ILibroServicio _libServicio;
        public EditarModel(ILibroServicio libSvr){
            _libServicio= libSvr;
        }
        public void OnGet(int Id)
        {
            var lista= _libServicio.MostrarTodos();
            LibroEd=lista.Where(x=>x.Id==Id).First();
        }
        public IActionResult OnPost()
        {
           _libServicio.Editar(LibroEd);
           return RedirectToPage("Listado");
        }
    }
}
