using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PadreHijo
{
    internal class videojuego:Consola
    {
        public videojuego(string genero, double precio, string modelo, int almacenamiento, int anio)
            : base( modelo,  almacenamiento,  anio)
        {
             
            Genero = genero;
            Precio = precio;
        }

        public string Genero { get; set; }
        public Double Precio { get; set; }
    }
}
