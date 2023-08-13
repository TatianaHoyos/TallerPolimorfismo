using TallerPolimorfismo.Animales;
using TallerPolimorfismo.Bibioteca;
using TallerPolimorfismo.figurasGeometricas;
using TallerPolimorfismo.Idiomas;
using TallerPolimorfismo.JuegoPersonajes;
using TallerPolimorfismo.Productos;
using TallerPolimorfismo.RedSocial;
using TallerPolimorfismo.TiendaOnline;
using TallerPolimorfismo.Vehiculos;

namespace TallerPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            //ejercicio#1
            // Circulo circulo = new Circulo(20);
            //    circulo.Area();
            //    circulo.Perimetro();
            // Triangulo triangulo= new Triangulo(20,30);
            //    triangulo.Area();
            //    triangulo.Perimetro();
            //Rectangulo rectangulo=new Rectangulo(20,30);
            //    rectangulo.Area();
            //    rectangulo.Perimetro();

            //ejercicio#2
            //Alimentos alimentos=new Alimentos();
            //alimentos.AgregarProducto("arroz", 10, 3000, 0.15);
            //alimentos.AgregarProducto("lentejas", 10, 2000, 0.1);
            //alimentos.PrecioProductos();

            //Ropa ropa = new Ropa();
            //ropa.AgregarProducto("camisa", 10, 30000, 0.15);
            //ropa.AgregarProducto("jeans", 10, 20000, 0.1);
            //ropa.PrecioProductos();

            //Electronico electronico = new Electronico();
            //electronico.AgregarProducto("nevera", 10, 3000000, 0.15);
            //electronico.AgregarProducto("tv", 10, 3000000, 0.15);
            //electronico.PrecioProductos();

            //ejercicio#3
            //Libro biblioteca = new Libro("biblioteca1",23,"tatiana","centro");
            //biblioteca.MostrarInfo();

            //Peliculas peliculas = new Peliculas("locacion1",2);
            //peliculas.MostrarInfo();

            //Canciones canciones = new Canciones("bailable","merengue",100);
            //canciones.MostrarInfo();

            //ejercicio#4
            //Gato gato = new Gato();
            //gato.HacerSonido();
            //Perro perro = new Perro();  
            //perro.HacerSonido();
            //Vaca vaca = new Vaca(); 
            //vaca.HacerSonido();

            //ejercicio#5
            //Tienda tienda= new Tienda();
            //Console.WriteLine("elija un metodo de pago");
            //Console.WriteLine("0. Tarjeta de Crédito");
            //Console.WriteLine("1. PayPal");
            //int opcion = Convert.ToInt32(Console.ReadLine());
            //MetodoPago metodoPago;
            //switch (opcion)
            //{
            //    case 0:
            //        metodoPago = new TarjetaCredito();
            //        break;
            //        case 1:
            //        metodoPago=new Paypal();
            //        break;
            //    default:
            //        Console.WriteLine("opcion no valida");
            //        return;


            //}

            //tienda.RealizarCompra(5000, metodoPago);

            //ejercicio#6
            //Automóviles  automóviles=new Automóviles();
            //automóviles.Avanzar();
            //Bicicleta bicicleta=new Bicicleta();
            //bicicleta.Avanzar();
            //Avion avion=new Avion();
            //avion.Avanzar();

            //ejercicio#7
            //Cubo cubo=new Cubo(10);
            //cubo.Area();
            //cubo.CalcularVolumen();
            //Conos conos = new Conos(12,32);
            //conos.Area();
            //conos.CalcularVolumen();
            //Esfera esfera = new Esfera(23);
            //esfera.Area();
            //esfera.CalcularVolumen();


            //ejercicio#8

            //Console.WriteLine("elija un Personaje");
            //Console.WriteLine("0. Guerrero");
            //Console.WriteLine("1. Magos");
            //Console.WriteLine("2. Arqueros");
            //int opcion = Convert.ToInt32(Console.ReadLine());

            //switch (opcion)
            //{
            //    case 0:
            //        Guerrero guerrero = new Guerrero();
            //        guerrero.Ataques();
            //        guerrero.Habilidades();
            //        break;
            //    case 1:
            //        Magos magos = new Magos();
            //        magos.Ataques();
            //        magos.Habilidades();
            //        break;
            //    case 2:
            //        Arqueros arqueros = new Arqueros();
            //        arqueros.Ataques();
            //        arqueros.Habilidades();
            //        break;
            //    default:
            //        Console.WriteLine("opcion no valida");
            //        return;
            //}

            //ejercicio#9
            //Console.WriteLine("escriba una frase corta");
            //string frase=Console.ReadLine();

            //Ingles ingles=new Ingles();
            //ingles.Traducir(frase);
            //Español español =new Español();
            //español.Traducir(frase);

            //ejercicio#10

            //RedSoocial redSoocial = new RedSoocial();

            //PublicarTexto texto = new PublicarTexto("¡Hola, amigos!");
            //redSoocial.AgregarPublicacion(texto);
            //PublicacionVideo video = new PublicacionVideo("perro.mp4");
            //redSoocial.AgregarPublicacion(video);
            //PublicacionImagen imagen = new PublicacionImagen("gato.png");
            //redSoocial.AgregarPublicacion(imagen);

            //redSoocial.MostrarPublicaciones();







        }
    }
}