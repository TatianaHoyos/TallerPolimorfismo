using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPolimorfismo.JuegoPersonajes
{
     class Personaje
    {
//        Juego de Personajes Crea un pequeño juego donde los jugadores
//puedan elegir entre diferentes tipos de personajes(por ejemplo, guerreros, magos,
//arqueros). Utiliza polimorfismo para implementar habilidades y ataques únicos
//para cada tipo de personaje.
     public virtual void Habilidades()
        {
            Console.WriteLine("su habilidad es:");
        }
        public virtual void Ataques()
        {
            Console.WriteLine("su ataque es:");
        }

    }
}
