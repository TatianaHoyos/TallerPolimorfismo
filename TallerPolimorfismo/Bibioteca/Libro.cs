using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPolimorfismo.Bibioteca
{
    class Libro:Biblioteca
    {
        private string nombre;
        private int cantidadLibros;
        private string administrador;
        private string ubicacion;

        public int CantidadLibros { get => cantidadLibros; set => cantidadLibros = value; }
        public string Administrador { get => administrador; set => administrador = value; }
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public Libro(string nombre, int paginas, string autor, string editorial)
        {
            Nombre = nombre;
            CantidadLibros = paginas;
            Administrador = autor;
            Ubicacion = editorial;
        }
        public override void MostrarInfo()
        {
            Console.WriteLine($"el nombre de la biblioteca es {Nombre}, la cantidad de libros que tiene es {CantidadLibros}, " +
                $"el nombre del administrador es {Administrador} y su hubicacion es {Ubicacion}");
        }
    }
}
