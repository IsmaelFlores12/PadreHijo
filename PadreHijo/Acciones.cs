using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadreHijo
{
    internal class Acciones
    {
        List<videojuego> ListaVenta = new List<videojuego>
        {
            new videojuego("Terror",60.0,"play5",12,2003),
            new videojuego("RPG",59.0,"Play4}",13,2007),
             new videojuego("Accion",59.0,"switch",17,2009),
            new videojuego("terror",23.0,"xboxS",11,2015),
             new videojuego("Batlee royal",55.0,"xboxS",12,2019),

        };
        public List<videojuego>mostrarP()
        {
            return ListaVenta;
        }
    }
}
