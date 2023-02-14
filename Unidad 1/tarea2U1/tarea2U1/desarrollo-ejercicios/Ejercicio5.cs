using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea2U1.desarrollo_ejercicios
{
    internal class Ejercicio5
    {
        public Ejercicio5()
        {
            int num;
            string linea;
            Console.WriteLine();
            Console.WriteLine("****MENU****\n");
            Console.WriteLine("Opcion 1: Hamburguesa\n", "Opcion 2: Pizza\n", "Opcion 3: Ensalada\n");
            Console.Write("Ingrese que desea comprar un numero del 1-3 :");
            linea = Console.ReadLine();
            num = int.Parse(linea);
            double precioH = 110.25;
            double precioP = 165.35;
            double precioE = 85.12;
          

            switch (num)
            {
                case 1:
                    Console.WriteLine("La hamburguesa tiene un precio de: " + precioH);
                    break;
                case 2:
                    Console.WriteLine("La pizza tiene un precio de: " + precioP);
                    break;
                case 3:
                    Console.WriteLine("La ensalada tiene un precio de: " + precioE);
                    break;
            }
        }
    }
}
