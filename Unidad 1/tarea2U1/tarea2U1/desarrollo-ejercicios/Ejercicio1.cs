using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea2U1.desarrollo_ejercicios
{
    internal class Ejercicio1
    {
        public Ejercicio1()
        {
            //Determinar si un numero es positivo, negativo o cero
            Console.WriteLine("Ingresa un numero: ");
            int num = int.Parse(Console.ReadLine());

            if (num == 0)
            {
                Console.WriteLine("El numero " + num + " es cero");
            }
            else
            {
                if (num > 0)
                {
                    Console.WriteLine("El numero " + num + " es positivo");
                }
                else
                {
                    Console.WriteLine("El numero " + num + " es negativo");
                }
            }
        }
    }
}
