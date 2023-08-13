using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPolimorfismo.Animales
{
     class Gato:Animales
    {
      
        public override void HacerSonido()
        {
            Console.WriteLine($"el gato hace miauuu");
        }
    }
}
