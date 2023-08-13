using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPolimorfismo.figurasGeometricas
{
    class Rectangulo:FigurasGeometricas
    {
        private double ancho;
        private double largo;

        public double Ancho { get => ancho; set => ancho = value; }
        public double Largo { get => largo; set => largo = value; }

        public Rectangulo(double ancho, double altura)
        {
            Ancho = ancho;
            Largo = altura;
        }

        public override void Area()
        {
            Console.WriteLine($"el area de un Rectangulo de {Ancho}X{Largo} es:  {Ancho * Largo}");


        }

        public override void Perimetro()
        {
            Console.WriteLine($"el perimetro de un Rectangulo de {Ancho}X{Largo} es: {2 * (Ancho + Largo)}");
        }
    }
}
