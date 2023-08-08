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
            return View();

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