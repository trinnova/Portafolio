using Portafolio.Servicios;
using System.Reflection.Metadata.Ecma335;

namespace Portafolio.Models
{
    public class HomeIndex
    {
        public IEnumerable<Proyecto> Proyectos { get; set; }
        public EjemploGUIDViewModel EjemploGUID_1 { get; set; }
    }
}
