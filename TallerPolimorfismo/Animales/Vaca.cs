﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPolimorfismo.Animales
{
    class Vaca:Animales
    {
        public override void HacerSonido()
        {
            Console.WriteLine($"la vaca hace Muuuu");
        }
    }
}
