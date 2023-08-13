using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPolimorfismo.Vehiculos
{
   class Avion:Vehiculos
    {
        public override void Avanzar()
        {
            Console.WriteLine("el avion avanza por el aire");
        }
    }
}
