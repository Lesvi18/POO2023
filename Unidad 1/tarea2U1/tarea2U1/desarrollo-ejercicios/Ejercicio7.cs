using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea2U1.desarrollo_ejercicios
{
    internal class Ejercicio7
    {
        public Ejercicio7()
        {
            Console.WriteLine("***SUMA DEL 1 AL 10***");
            int suma = 0;

            for (int i = 1; i <= 10; i++)
            {
                suma = suma + i;
            }
            Console.WriteLine("La suma de los numeros del 1 al 10 es: " + suma);
        }
    }
}
