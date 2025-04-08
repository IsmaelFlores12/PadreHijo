using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadreHijo
{
    internal class Acciones
    {
        videojuego a = new videojuego();

        List<videojuego> ListaVenta = new List<videojuego>
        {
            new videojuego("Terror",60.0,"play5",12,2003),
            new videojuego("RPG",59.0,"Play4}",13,2007),
             new videojuego("Accion",59.0,"switch",17,2009),
            new videojuego("terror",23.0,"xboxS",11,2015),
             new videojuego("Batlee royal",55.0,"xboxS",12,2019),

        };
        public List<videojuego> mostrarP()
        {
            return ListaVenta;
        }

        public bool EliminarJuego(int año)
        {
            try
            {
                var objecEliminar = ListaVenta.Find(x => x.Anio == año);
                if (objecEliminar != null)
                {
                    ListaVenta.Remove(objecEliminar);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool InsertarJuego(string genero, double precio, string modelo, int almacenamiento, int anio)
        {
            try
            {
                ListaVenta.Add(new videojuego(a.Genero = genero, a.Precio = precio, a.Modelo = modelo, a.Almacenamiento = almacenamiento, a.Anio = anio));
                return true;
            }
            catch (Exception)
            {
                return false;

            }

        }
        public bool actualizar(string genero, double precio, string modelo, int almacenamiento, int anio)
        {
            try
            {
                var objetoActulizar = ListaVenta.Find(x => x.Genero == genero);
                if (objetoActulizar != null)
                {
                    objetoActulizar.Genero = genero;
                    objetoActulizar.Precio = precio;
                    objetoActulizar.Modelo = modelo;
                    objetoActulizar.Almacenamiento = almacenamiento;
                    objetoActulizar.Anio = anio;
                    return true;
                }
                return true;
            }
            catch(Exception) { return false; }
        }
    }
}
