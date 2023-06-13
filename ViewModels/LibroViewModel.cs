using Libreria.Models;

namespace Libreria.ViewModels;

public class LibroViewModel
{

    public List<Libro>? Libros{get;set;} = new List<Libro>();

    public string NombreFiltrado{get;set;}
}