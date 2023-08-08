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
        private readonly ServicioDelimitado servicioDelimitado;
        private readonly ServicioUnico servicioUnico;
        private readonly ServicioTransitorio servicioTransitorio;

        public HomeController(ILogger<HomeController> logger, 
            IRepositorioProyectos repositorioProyectos,
            ServicioDelimitado servicioDelimitado,
            ServicioUnico servicioUnico,
            ServicioTransitorio servicioTransitorio
            )
        {
            _logger = logger;
            this.repositorioProyectos = repositorioProyectos;
            this.servicioDelimitado = servicioDelimitado;
            this.servicioUnico = servicioUnico;
            this.servicioTransitorio = servicioTransitorio;
        }

        // Acciones: son las funciones que se ejecutan cuando hacemos una petición http
        public IActionResult Index()
        {            
            var proyectos = repositorioProyectos.ObtenerProyectos().Take(3).ToList();

            var guidViewModel = new EjemploGUIDViewModel()
            {
                Delimitado = servicioDelimitado.ObtenerGuid,
                Transitorio = servicioTransitorio.ObtenerGuid,
                Unico = servicioUnico.ObtenerGuid
            };

            var modelo = new HomeIndex() 
            { 
                Proyectos = proyectos,
                EjemploGUID_1 = guidViewModel
            };

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

        public IActionResult Proyectos()
        {
            var proyectos = repositorioProyectos.ObtenerProyectos();
            return View(proyectos);
        }   

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}