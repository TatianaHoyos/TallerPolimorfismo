using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPolimorfismo.figurasGeometricas
{
     class Triangulo:FigurasGeometricas
    {
        private double baseT;
        private double altura;

        public double BaseT { get => baseT; set => baseT = value; }
        public double Altura { get => altura; set => altura = value; }

        public Triangulo(double baseT, double altura)
        {
            BaseT = baseT;
            Altura = altura;
        }

        public override void Area()
        {
            Console.WriteLine($"el area de un triangulo de {BaseT}X{Altura} es:  {(BaseT * Altura) / 2}");


        }

        public override void Perimetro()
        {
            Console.WriteLine($"el perimetro de un triangulo de {BaseT}X{Altura} es: {BaseT + Altura + BaseT}");
        }
    }
}
