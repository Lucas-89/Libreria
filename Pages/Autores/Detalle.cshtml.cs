using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LibreriaDigital.Modelos;
using LibreriaDigital.Pages.Autores;
using LibreriaDigital.Servicios;

namespace LibreriaDigital.Pages.Autores
{
    public class DetalleModel : PageModel
    {
        [BindProperty]
        public Autor AutorDet{get;set;}

        private IAutorServicio _autorserv;

        public DetalleModel(IAutorServicio autorSvr){
            _autorserv= autorSvr;
        }
        public void OnGet(int Id)
        {
            var detalle= _autorserv.MostrarTodos();
            AutorDet= detalle.Where(x=>x.Id==Id).First();
        }
    }
}

