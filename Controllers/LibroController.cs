using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Libreria.Data;
using Libreria.Models;
using Libreria.ViewModels;
using Libreria.Services;

namespace Libreria.Controllers
{
    public class LibroController : Controller
    {
        private ILibroService _libroService;
        private IAutorService _autorService;

        public LibroController(
            ILibroService libroService,
            IAutorService autorService
            )
        {
            _libroService = libroService;
            _autorService = autorService;
        }

        // GET: Libro
        public IActionResult Index() //aca estaba async
        {
            var list =_libroService.GetAll();
            return View(list);
        }

        // GET: Libro/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null )
            {
                return NotFound();
            }

            var libro = _libroService.GetById(id.Value);
            if (libro == null)
            {
                return NotFound();
            }

            return View(libro); 
        }

        // GET: Libro/Create
        public IActionResult Create()
        {
            var autorList = _autorService.GetAll();
            ViewData["AutorId"] = new SelectList(autorList, "Id", "Id");
            return View();
        }

        // POST: Libro/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Titulo,Genero,CantPaginas,AutorId, autores")] LibroCreateViewModel libro)
        {
            var autores = _autorService.GetAll().Where(x=> libro.AutorId.Equals(x.Id)).ToList();
            
            var viewModel = new Libro();
            viewModel.Id= libro.Id;
            viewModel.Titulo = libro.Titulo;
            viewModel.CantPaginas = libro.CantPaginas;
            viewModel.Autor = (Autor)autores; 
            
            
            //TODO:
            // ver si aca es donde deberia poner una funcion 
            // para que aparezca el nombre y no el id del autor
            if (ModelState.IsValid)
            {
                _libroService.Create(viewModel);
                return RedirectToAction(nameof(Index));
            }
            var autor = _autorService.GetAll();
           ViewData["AutorId"] =new SelectList (autor,"Id", "NombreAutor"); //todavia no hice el _autorService
            return View(viewModel);
        }

        // GET: Libro/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var libro = _libroService.GetById(id.Value);
            if (libro == null)
            {
                return NotFound();
            }
           // ViewData["AutorId"] = new SelectList(_context.Autor, "Id", "Id", libro.AutorId); //aca tambien necesito el _autorService
            return View(libro);
        }

        // POST: Libro/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Titulo,Genero,CantPaginas,AutorId")] Libro libro)
        {
            if (id != libro.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _libroService.Update(libro);
                return RedirectToAction(nameof(Index));
            }
           // ViewData["AutorId"] = new SelectList(_context.Autor, "Id", "Id", libro.AutorId);
            return View(libro);
        }

        // GET: Libro/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null )
            {
                return NotFound();
            }

            var libro = _libroService.GetById(id.Value);
            if (libro == null)
            {
                return NotFound();
            }

            return View(libro);
        }

        // POST: Libro/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var libro = _libroService.GetById(id);
            if (libro != null)
            {
                _libroService.Delete(libro);
            }
            
            
            return RedirectToAction(nameof(Index));
        }

        private bool LibroExists(int id)
        {
          return _libroService.GetById(id) != null;
        }
    }
}
