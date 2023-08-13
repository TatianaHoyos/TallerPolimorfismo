using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TallerPolimorfismo.Animales
{
     class Animales
    {
//        Animales y Sonidos Diseña una jerarquía de clases que representen
//diferentes tipos de animales.Utiliza polimorfismo para permitir que cada animal
//emita su propio sonido característico cuando se llama a un método
//HacerSonido().

        public virtual void HacerSonido()
        {
            Console.WriteLine("el animal emite un sonido");
        }


    }
}
