using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LibreriaDigital.Servicios;
using LibreriaDigital.Pages.Autores;
using LibreriaDigital.Modelos;

namespace LibreriaDigital.Pages.Autores
{
    public class ListadoModel : PageModel
    {
        [BindProperty]
        public List<Autor> ListaAutores{get;set;}
        private IAutorServicio _autorServicio;
        public string NombreOrdenado;
        public ListadoModel(IAutorServicio autorsrv){
            _autorServicio = autorsrv; // tengo que saber que tiene esto adentro
        }
        public void OnGet(string FiltroNombre, string CampoOrden)
        {

            NombreOrdenado = (CampoOrden=="Nombre_Asc") ? "Nombre_Desc": "Nombre_Asc";

           ListaAutores=_autorServicio.MostrarTodos();
           if (FiltroNombre!=null && FiltroNombre.Length>0)
           {
                ListaAutores=ListaAutores.Where(x=>x.Nombre.ToUpper().Contains(FiltroNombre.ToUpper())).ToList();
           }
           /*
           if(CampoOrden=="OrdenNombre")
           {
                ListaStock=ListaStock.OrderBy(x=>x.Nombre).ToList();
           }
           */
           switch(CampoOrden){
            case "Nombre_Asc":
                ListaAutores=ListaAutores.OrderBy(x=>x.Nombre).ToList();
                break;
            case "Nombre_Desc":
                ListaAutores=ListaAutores.OrderByDescending(x=>x.Nombre).ToList();
                break;
            default:
                ListaAutores=ListaAutores.OrderBy(x=>x.Id).ToList();
            break;
           }
        }

        public void OnGetBorrar(int IdBorar){
            var libroborrar= _autorServicio.MostrarTodos().Where(x=>x.Id==IdBorar).First();
            _autorServicio.Eliminar(libroborrar);
            ListaAutores= _autorServicio.MostrarTodos();

        }

    } 
}
