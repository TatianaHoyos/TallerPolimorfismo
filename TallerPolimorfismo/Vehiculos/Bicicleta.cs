using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPolimorfismo.Vehiculos
{
     class Bicicleta:Vehiculos
    {
        public override void Avanzar()
        {
            Console.WriteLine("la bicicleta avanza con sus 2 ruedas por el suelo");
        }
    }
}
