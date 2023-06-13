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
    public class AutorController : Controller
    {
        private readonly IAutorService _autorService;

        public AutorController(IAutorService autorService)
        {
            _autorService = autorService;
        }

        // GET: Autor
        public IActionResult Index(string NombreBuscado)
        {
            var model = new AutorViewModel();
            model.Autores= _autorService.GetAll(NombreBuscado);

            return View(model);
        }

        // GET: Autor/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null )
            {
                return NotFound();
            }

            var autor = _autorService.GetById(id.Value);
            if (autor == null)
            {
                return NotFound();
            }

            var viewModel = new AutorDetailViewModel();
            viewModel.Nombre = autor.Nombre;
            viewModel.Nacionalidad = autor.Nacionalidad;
            viewModel.Libros= autor.Libros !=null? autor.Libros : new List<Libro>();

            return View(viewModel);
        }

        // GET: Autor/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Autor/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Nombre,Nacionalidad,Contemporaneo")] AutorCreateViewModel autor)
        {
            var autorModel = new Autor();
            autorModel.Id = autor.Id;
            autorModel.Nombre = autor.Nombre;
            autorModel.Nacionalidad = autor.Nacionalidad;
            autorModel.Contemporaneo = autor.Contemporaneo;
            if (ModelState.IsValid)
            {
                _autorService.Create(autorModel);
                return RedirectToAction(nameof(Index));
            }
            return View(autor);
        }

        // GET: Autor/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null )
            {
                return NotFound();
            }

            var autor = _autorService.GetById(id.Value);
            if (autor == null)
            {
                return NotFound();
            }
            return View(autor);
        }

        // POST: Autor/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Nombre,Nacionalidad,Contemporaneo")] Autor autor)
        {
            if (id != autor.Id)
            {
                return NotFound();
            }
            // TODO: arreglar esto
            ModelState.Remove("Libros");
            if (ModelState.IsValid)
            {
                try
                {
                    _autorService.Update(autor);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AutorExists(autor.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(autor);
        }

        // GET: Autor/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null )
            {
                return NotFound();
            }

            var autor = _autorService.GetById(id.Value);
            if (autor == null)
            {
                return NotFound();
            }

            return View(autor);
        }

        // POST: Autor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _autorService.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        private bool AutorExists(int id)
        {
          return _autorService.GetById(id) != null;
        }
    }
}
