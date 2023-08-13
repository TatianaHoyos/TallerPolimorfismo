using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPolimorfismo.JuegoPersonajes
{
    internal class Magos : Personaje

    {
        public override void Ataques()
        {
            Console.WriteLine("el ataque electrocutar");
            Console.WriteLine("el ataque misil magico");
        }
        public override void Habilidades()
        {
            Console.WriteLine("La habilidad es teletransporte");
            Console.WriteLine("La habilidad es combatir a distancia");
        }
    
    }
}
