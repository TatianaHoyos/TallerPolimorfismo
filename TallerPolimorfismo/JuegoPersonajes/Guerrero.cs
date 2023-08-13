using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPolimorfismo.JuegoPersonajes
{
     class Guerrero:Personaje

    {
        public override void Ataques()
        {
            Console.WriteLine("el ataque con catana");
            Console.WriteLine("el ataque con arma de fuego");
        }
        public override void Habilidades()
        {
            Console.WriteLine("La habilidad es golpe critico");
            Console.WriteLine("La habilidad es detnador cuerpo a cuerpo");
        }
    }
}
