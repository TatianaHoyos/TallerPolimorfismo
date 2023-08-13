using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPolimorfismo.Bibioteca
{
     class Peliculas:Biblioteca
    {
        private string setGrabacion;
        private int tiempo;

        public string SetGrabacion { get => setGrabacion; set => setGrabacion = value; }
        public int Tiempo { get => tiempo; set => tiempo = value; }

        public Peliculas(string setGrabacion, int tiempo)
        {
            SetGrabacion = setGrabacion;
            Tiempo = tiempo;
        }

        public override void MostrarInfo()
        {
            Console.WriteLine($"el set donde graban es {SetGrabacion}, la cantidad de tiempo que demoran grabando es {Tiempo}, horas");
        }
    }
}
