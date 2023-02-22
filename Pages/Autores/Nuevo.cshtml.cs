using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LibreriaDigital.Modelos;
using LibreriaDigital.Servicios;

namespace LibreriaDigital.Pages.Autores
{
    public class NuevoModel : PageModel
    {
        [BindProperty]
       public Autor AutorIng{get;set;}
       
       private IAutorServicio _autorIngresado;
       public NuevoModel(IAutorServicio autoring){
          _autorIngresado =autoring;
       }
        public void OnGet()
        {
          
        }
        public IActionResult OnPost()
        {
          _autorIngresado.Agregar(AutorIng);
          return RedirectToPage("Listado");
        }
    }
}