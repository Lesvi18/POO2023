using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen1.examenUnidad1
{
    internal class Ejercicio2
    {
        public Ejercicio2()
        {
            Console.WriteLine("****LISTA DE NUMEROS ENTEROS****");
            Console.WriteLine("Ingrese la cantidad de numeros: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                num = num + 1;
                Console.WriteLine("El numero mas comun es: " + num);
                i++;
            }
        }
    }
}
