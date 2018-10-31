using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_Sesion_3
{

    public class Coordenada
    {
        public Double latitude { get; set; }
        public Double longitude { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
      
        {
            bool Continuar = true;

            Console.WriteLine("Ingrese coordenadas (latitud, longitud), y presiona ENTER, 'x' para terminar:");
            Console.WriteLine("Ejemplo: 12.3444,14.2333");
            Console.WriteLine("_______________________________________________________________");
            List<Coordenada> coordenadas = new List<Coordenada>();

            
            while (Continuar)
            {
                String input = Console.ReadLine();
                if (input.ToLower().Equals("x"))
                {
                    Continuar = false;
                    continue;
                }
                if (input.Split(',').Length != 2)
                {
                    continue;
                }
                // todo lo que es correcto
                Double latitud;
                Double longitud;
                Coordenada mycoord = new Coordenada()
                {
                    latitude = Double.TryParse(input.Split(',')[0], out latitud) ? latitud:0,
                    longitude = Double.TryParse(input.Split(',')[1], out longitud) ? longitud : 0,
                };

                coordenadas.Add(mycoord);

                
            

            }
            string Link = string.Empty;
            //string asd = "";
            foreach (Coordenada cor in coordenadas)
                
            {
                Link = Link + cor.latitude.ToString() + "%2C%20" + cor.longitude.ToString() + "%0A";
              
            }

            Console.WriteLine("El link de las coordenadas es: https://www.keene.edu/campus/maps/tool/?coordinates={0}", Link);
            System.Diagnostics.Process.Start("https://www.keene.edu/campus/maps/tool/?coordinates="+Link);
            Console.WriteLine("_______________________________________________________________");
            Console.WriteLine("Adios, gracias por usar esta app, ingresaste {0} coordenadas", coordenadas.Count);
            Console.ReadKey();
        }
        
    }
}
