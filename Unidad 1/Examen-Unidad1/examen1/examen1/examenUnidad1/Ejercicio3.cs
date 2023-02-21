using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen1.examenUnidad1
{
    internal class Ejercicio3
    {
        public Ejercicio3()
        {
            Console.WriteLine("***MATRIZ CUADRADA***");
            Console.WriteLine("Ingrese el tamaño de la matriz cuadrada: ");
            int tamaño = int.Parse(Console.ReadLine());

            int matriz = new matriz[];
            Random numrandom = new Random();
            int sumaC = 1;
            int sumaF = 1;  

            for (int f = 0; f < matriz; f++)
            {
                for (int c = 0; c < matriz; c++)
                {
                    sumaC = numrandom.Next(1, 100);
                    Console.WriteLine("La suma de las columnas es: " + sumaC);
                }

                sumaF = numrandom.Next(1, 100);
                Console.WriteLine("La suma de las filas es: " + sumaF);
            }
        }
    }
}
