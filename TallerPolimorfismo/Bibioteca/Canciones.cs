using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPolimorfismo.Bibioteca
{
 class Canciones:Biblioteca
    {
        private string nombreLista;
        private string genero;
        private int cantidadLista;

        public string NombreLista { get => nombreLista; set => nombreLista = value; }
        public string Genero { get => genero; set => genero = value; }
        public int CantidadLista { get => cantidadLista; set => cantidadLista = value; }

        public Canciones(string nombreLista, string genero, int cantidadLista)
        {
            NombreLista = nombreLista;
            Genero = genero;
            CantidadLista = cantidadLista;
        }
        public override void MostrarInfo()
        {
            Console.WriteLine($"el nombre de la lista de canciones es {NombreLista}, el genero de las canciones es {Genero}, y la cantidad de lista es {CantidadLista}");
        }
    }
}
