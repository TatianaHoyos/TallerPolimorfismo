using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPolimorfismo.figurasGeometricas
{
    class Cubo:FigurasGeometricas
    {
        private double lado;

        public double Lado { get => lado; set => lado = value; }

        public Cubo(double lado)
        {
            Lado = lado;
        }

        public override void Area()
        {
            Console.WriteLine($"el area de un cubo con lado {Lado} es:  {6 * Lado * Lado}");


        }
        public override void CalcularVolumen()
        {
            Console.WriteLine($"el volumen de un cubo con lado {Lado} es:  {Lado * Lado * Lado}");


        }
    }
}
