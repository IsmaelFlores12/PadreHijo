using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadreHijo
{
    internal class Consola
    {
        public Consola() { }

        public Consola(string modelo, int almacenamiento, int anio)
        {
            Modelo = modelo;
            Almacenamiento = almacenamiento;
            Anio = anio;
        }

        public String Modelo { get; set; }
        public int Almacenamiento { get; set; }
        public int Anio { get; set; }


    }
}
