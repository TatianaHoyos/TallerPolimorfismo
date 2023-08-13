using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPolimorfismo.figurasGeometricas
{
    class Circulo: FigurasGeometricas
    {
        private double radio;

        public double Radio { get => radio; set => radio = value; }

        public Circulo(double radio)
        {
            Radio = radio;
        }

        public override void Area()
        {
            Console.WriteLine($"el area de un circulo con radio {Radio} es:  {Math.PI * Radio * Radio}");
           

        }

        public override void Perimetro()
        {
         Console.WriteLine( $"el perimetro de un circulo con radio {Radio} es: { 2 * Math.PI * Radio}");
        }

    }
}
