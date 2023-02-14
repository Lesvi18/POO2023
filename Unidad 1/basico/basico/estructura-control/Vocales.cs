using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace basico.estructura_control
{
    internal class Vocales
    {
        public Vocales()
        {
            Console.WriteLine("Nombres segun la vocal");
            Console.WriteLine("--------------------\n");

            Console.WriteLine("Ingrese una vocal");
            char vocal = Console.ReadLine()[0];

            switch (vocal) 
            {
                case 'a':
                    Console.WriteLine("Abel, Angel, Andrea, Ana, Antonia");
                    break;
                case 'e':
                    Console.WriteLine("Erick, Esteban, Edgardo, Erika, Esmeralda");
                    break;
                case 'i':
                    Console.WriteLine("Isis, Isabel, Isidoro, Ivan, Iris");
                    break;
                case 'o':
                    Console.WriteLine("Omar, Oscar, Orfilia, Ovidio, Octavio");
                    break;
                case 'u':
                    Console.WriteLine("Ulises, Ursula, Uriel, Uriana, Ubaldo");
                    break;
                default:
                    Console.WriteLine("La vocal no es valida");
                    break;
            }
        }

    }
}
