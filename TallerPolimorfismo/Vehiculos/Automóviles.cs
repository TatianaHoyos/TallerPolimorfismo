using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPolimorfismo.Vehiculos
{
   class Automóviles:Vehiculos
    {
        public override void Avanzar()
        {
            Console.WriteLine("el vehiculo avanza con sus 4 ruedas por el suelo");
        }
    }
}
