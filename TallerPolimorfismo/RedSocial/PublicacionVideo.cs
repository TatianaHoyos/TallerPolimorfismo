using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPolimorfismo.RedSocial
{
    internal class PublicacionVideo : Publicacion
    {
        public string Contenido { get; set; }

        public PublicacionVideo(string contenido)
        {
            Contenido = contenido;
        }

        public override void Mostrar()
        {
            Console.WriteLine($"publicaste un video: {Contenido}");
        }
    }
   
}
