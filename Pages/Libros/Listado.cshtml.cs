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
        public string NombreOrdenado;
        public ListadoModel(ILibroServicio libsrv){
            _libroServicio = libsrv; // tengo que saber que tiene esto adentro
        }
        public void OnGet(string FiltroNombre, string CampoOrden)
        {

            NombreOrdenado = (CampoOrden=="Nombre_Asc") ? "Nombre_Desc": "Nombre_Asc";

           ListaStock=_libroServicio.MostrarTodos();
           if (FiltroNombre!=null && FiltroNombre.Length>0)
           {
                ListaStock=ListaStock.Where(x=>x.Nombre.ToUpper().Contains(FiltroNombre.ToUpper())).ToList();
           }
           /*
           if(CampoOrden=="OrdenNombre")
           {
                ListaStock=ListaStock.OrderBy(x=>x.Nombre).ToList();
           }
           */
           switch(CampoOrden){
            case "Nombre_Asc":
                ListaStock=ListaStock.OrderBy(x=>x.Nombre).ToList();
                break;
            case "Nombre_Desc":
                ListaStock=ListaStock.OrderByDescending(x=>x.Nombre).ToList();
                break;
            default:
                ListaStock=ListaStock.OrderBy(x=>x.Id).ToList();
            break;
           }
        }

        public void OnGetBorrar(int IdBorar){
            var libroborrar= _libroServicio.MostrarTodos().Where(x=>x.Id==IdBorar).First();
            _libroServicio.Eliminar(libroborrar);
            ListaStock= _libroServicio.MostrarTodos();

        }

    } 
}
