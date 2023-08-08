using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Acciones: son las funciones que se ejecutan cuando hacemos una petición http
        public IActionResult Index()
        {
            var proyectos = ObtenerProyectos().Take(3).ToList();

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

        private List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>()
            {
                new Proyecto 
                { 
                    Titulo = "Amazon",
                    Descripcion = "E-Commerce realizado en ASP.NET CORE",
                    Link = "https://amazon.com",
                    ImagenURL = "/img/amazon.png"
                },

                new Proyecto
                {
                    Titulo = "New York Times",
                    Descripcion = "Página de noticias en REACT",
                    Link = "https://nytimes.com",
                    ImagenURL = "/img/nyt.png"
                },

                new Proyecto
                {
                    Titulo = "Reddit",
                    Descripcion = "Red Social para compartir en comunidades",
                    Link = "https://reddit.com",
                    ImagenURL = "/img/reddit.png"
                },
                new Proyecto
                {
                    Titulo = "STEAM",
                    Descripcion = "Tíenda en línea para comprar videojuegos",
                    Link = "https://store.steampowered.com",
                    ImagenURL = "/img/steam.webp"
                }
            };
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