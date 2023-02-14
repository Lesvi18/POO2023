using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea2U1.desarrollo_ejercicios
{
    internal class Ejercicio2
    {
        public Ejercicio2()
        {
            //Ingresar dos numeros y determinar cual es mayor

            Console.WriteLine("****INGRESO DE DOS NUMEROS****");

            Console.WriteLine("Ingrese numero 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese numero 2: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("El numero mayor es " + num1);
            }
            else
            {
                Console.WriteLine("El numero mayor es " + num2);
            }
        }
    }
}
