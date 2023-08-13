using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPolimorfismo.RedSocial
{
    class PublicacionImagen : Publicacion
    {
        public string Contenido { get; set; }

        public PublicacionImagen(string contenido)
        {
            Contenido = contenido;
        }

        public override void Mostrar()
        {
            Console.WriteLine($"publicaste una imagen: {Contenido}");
        }
    
    }
}
