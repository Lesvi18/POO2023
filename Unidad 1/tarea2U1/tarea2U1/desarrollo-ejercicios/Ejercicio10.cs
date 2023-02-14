using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea2U1.desarrollo_ejercicios
{
    internal class Ejercicio10
    {
        public Ejercicio10()
        {
            Console.WriteLine("----SUMA DE NUMEROS PARES DEL 1 AL 100----");
            int n = 1;
            int suma = 0;

            while (n <= 100)
            {
                if (n % 2 == 0)
                {
                    suma = suma + n;
                }
                n++;
            }
            Console.WriteLine("La suma de los numeros pares es: " + suma);
        }
    }
}
