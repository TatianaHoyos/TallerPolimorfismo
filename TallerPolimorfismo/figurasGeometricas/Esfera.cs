using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPolimorfismo.figurasGeometricas
{
    class Esfera:FigurasGeometricas
    {
        private double radio;

        public double Radio { get => radio; set => radio = value; }

        public Esfera(double radio)
        {
            Radio = radio;
        }

        public override void Area()
        {
            Console.WriteLine($"el area de una esfera con radio {Radio} es:  {4 * Math.PI * Radio * Radio}");


        }
        public override void CalcularVolumen()
        {
            Console.WriteLine($"el volumen de una esfera con radio {Radio} es:  {(4 / 3) * Math.PI * Radio * Radio * Radio}");


        }
    }
}
