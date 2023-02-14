using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea2U1.desarrollo_ejercicios
{
    internal class Ejercicio11
    {
        public Ejercicio11()
        {
            Console.WriteLine("****TABLA DE MULTIPLICAR****");


            Console.WriteLine("Ingresa un numero: ");
            int num = 1;
            int m = int.Parse(Console.ReadLine());

            while (num <= 10)
            {
                for (int i = 1; i < m; i++)
                {
                    num = m * num;
                }
                Console.WriteLine(num + " x " + m + " = " + num);
            }
        }
    }
}
