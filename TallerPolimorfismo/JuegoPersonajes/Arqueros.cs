using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPolimorfismo.JuegoPersonajes
{
     class Arqueros : Personaje

    {
        public override void Ataques()
        {
            Console.WriteLine("el ataque flecha buscadora");
            Console.WriteLine("el ataque lluvia de flechas");
        }
        public override void Habilidades()
        {
            Console.WriteLine("La habilidad es conjuros por dia ");
            Console.WriteLine("La habilidad es combatir a distancia");
        }
    
    }
}
