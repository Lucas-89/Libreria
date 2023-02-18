using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LibreriaDigital.Modelos;
using LibreriaDigital.Servicios;

namespace LibreriaDigital.Pages.Libros
{
    public class NuevoModel : PageModel
    {   
        [BindProperty]
       public Libro LibroIng{get;set;}
       
       private ILibroServicio _libIngresado;
       public NuevoModel(ILibroServicio libing){
          _libIngresado =libing;
       }
        public void OnGet()
        {
          
        }
        public IActionResult OnPost()
        {
          _libIngresado.Agregar(LibroIng);
          return RedirectToPage("Listado");
        }
    }
}
