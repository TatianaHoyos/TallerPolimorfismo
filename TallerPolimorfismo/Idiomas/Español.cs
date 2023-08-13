using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPolimorfismo.Idiomas
{
    class Español : Idiomas
    {
        public void Traducir(string frase)
        {
            Console.WriteLine($"esta frase '{frase}' es traducida en español");
        }
    }
    

}
