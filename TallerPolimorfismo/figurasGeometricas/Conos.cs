using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPolimorfismo.figurasGeometricas
{
     class Conos : FigurasGeometricas
    {
        private double radio;
        private double altura;

        public double Radio { get => radio; set => radio = value; }
        public double Altura { get => altura; set => altura = value; }

        public Conos(double radio, double altura)
        {
            Radio = radio;
            Altura=altura;
        }

        public override void Area()
        {
            Console.WriteLine($"el area de un cono con radio {Radio} y{Altura} es:  {Math.PI * Radio * (Radio + Altura)}");


        }
        public override void CalcularVolumen()
        {
            Console.WriteLine($"el volumen de un cono con radio {Radio}y {Altura} es:  {(1 / 3) * Math.PI * Radio * Radio * Altura}");


        }
    
    }
}
