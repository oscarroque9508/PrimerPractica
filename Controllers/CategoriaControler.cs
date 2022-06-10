using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PrimerPractica.Models;

namespace PrimerPractica.Controllers{
    public class CategoriaController : Controller
    {
        public IActionResult Index()
        {
            var categoria = new Categoria();
            categoria.Id = 001;
            categoria.Nombre = "Serigrafia";
            //Categoria.Activo = true;
            //Categoria.Seleccion = false;
            return View(categoria);
        }

        public IActionResult MultiCategoria()
        {
            var ListCategora = new List<Categoria>()
            {
                new Categoria{Id=1, Nombre = "Serigrafia", Activo = true, Seleccion = true},
                new Categoria{Id=2, Nombre = "Imprenta", Activo = true, Seleccion = true},
                new Categoria{Id=3, Nombre = "Bordados", Activo = true, Seleccion = true},
                new Categoria{Id=4, Nombre = "Gran Formato", Activo = true, Seleccion = true}
            };
            return View(ListCategora);
        }
    }
}