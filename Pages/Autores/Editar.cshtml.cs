using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LibreriaDigital.Servicios;
using LibreriaDigital.Pages.Autores;
using LibreriaDigital.Modelos;

namespace LibreriaDigital.Pages.Autores
{
    public class EditarModel: PageModel
    {
        [BindProperty]
        public Autor AutorEd{get;set;}

        private IAutorServicio _autorServicio;
        public EditarModel(IAutorServicio autorSvr){
            _autorServicio= autorSvr;
        }
        public void OnGet(int Id)
        {
            var lista= _autorServicio.MostrarTodos();
            AutorEd=lista.Where(x=>x.Id==Id).First();
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
              _autorServicio.Editar(AutorEd);
           return RedirectToPage("/Autores/Listado");  
            }
           else{
                return Page();
           }
        }
    }
}