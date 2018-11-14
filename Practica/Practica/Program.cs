using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    class Program
    {
        public class Coord
        {
            public Double Latitud { get; set; }
            public Double Longitud { get; set; }
        }
        static void Main(string[] args)
        {
            bool Continuar = true;
            Console.WriteLine("Ingrese coordenadas (Latitud, Longitud) ó 'x' para salir");
            Console.WriteLine("Ejemplo: 1.4, 2.5");
            List<Coord> coordenadas = new List<Coord>();
            while (Continuar)
            {
                string input = Console.ReadLine();
                if (input.ToLower().Equals("x"))
                {
                    Continuar = false;
                }
                if (input.Split(',').Length != 2)
                {
                    continue;
                }
                Double LAT;
                Double LON;
                Coord mycoord = new Coord()
                {
                    Latitud = Double.TryParse(input.Split(',')[0], out LAT) ? LAT : 0,
                    Longitud = Double.TryParse(input.Split(',')[1], out LON) ? LON : 0,
                };
                coordenadas.Add(mycoord);
            }
            string Coordenadas = "";
            foreach (Coord Direccion in coordenadas)
            {
                Coordenadas = Coordenadas + Convert.ToString(Direccion.Latitud) + "%2C%20" + Convert.ToString(Direccion.Longitud) + "%0A";
            }
            Console.WriteLine("Direccion de Coordenadas:");
            Console.WriteLine("https://www.keene.edu/campus/maps/tool/?coordinates{0}", Coordenadas);
            Console.WriteLine("Usted ingresó {0} coordenadas, hasta la proxima!", coordenadas.Count);
            Console.ReadKey();
        }
    }
}
