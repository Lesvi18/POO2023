using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea2U1.desarrollo_ejercicios
{
    internal class Ejercicio8
    {
        public Ejercicio8()
        {
            Console.WriteLine("FACTORIAL DE UN NUMERO");
            float factorial = 1;
            Console.WriteLine("Ingresa un numero: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine("El factorial del numero es: " + factorial);
        }
    }
}
