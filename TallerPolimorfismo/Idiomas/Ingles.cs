using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPolimorfismo.Idiomas
{
    class Ingles : Idiomas
    {
        public void Traducir(string frase)
        {
            Console.WriteLine($"this phrase '{frase}' is translated in inglish");
        }
    }
}
