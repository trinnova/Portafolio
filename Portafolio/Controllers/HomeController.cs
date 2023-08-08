using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Servicios;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositorioProyectos repositorioProyectos;

        public HomeController(ILogger<HomeController> logger, IRepositorioProyectos repositorioProyectos)
        {
            _logger = logger;
            this.repositorioProyectos = repositorioProyectos;
        }

        // Acciones: son las funciones que se ejecutan cuando hacemos una petición http
        public IActionResult Index()
        {            
            var proyectos = repositorioProyectos.ObtenerProyectos().Take(3).ToList();

            var modelo = new HomeIndex() { Proyectos = proyectos };

            //var persona = new Persona()
            //{
            //    Nombre = "Heriberto",
            //    Edad = 30
            //};

            //// Pasamos datos del controlador a la Vista
            //ViewBag.Nombre = "OMAR GARCÍA";

            //ViewBag.Edad = 29;

            //// Lo usamos junto con el @model que esta en el Index.cshtml
            ////return View("Index", "Omar García");
            return View(modelo);

            /*
             * return View("Index2);
             * Esto funciona si al archivo de la carpeta: Views
             * index.cshtml, lo cambiamos a index2, 
             * esto con la finalidad de encontrar el archivo y
             * lea en la vista 
            */
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}