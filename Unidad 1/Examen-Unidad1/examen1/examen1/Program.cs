using examen1.examenUnidad1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***MENU DE EJERCICIOS***");
            Console.WriteLine("Ingrese un numero del 1-4: ");
            int menu = int.Parse(Console.ReadLine());   

            switch (menu)
            {
                case 1:
                    Ejercicio1 ejercicio1 = new Ejercicio1();
                    break;
                case 2:
                    Ejercicio2 ejercicio2 = new Ejercicio2();
                    break;
                case 3:
                    Ejercicio3 ejercicio3 = new Ejercicio3();
                    break;
                case 4:
                    Ejercicio5 ejercicio5 = new Ejercicio5();
                    break;
            }


            //Ejercicio1 ejercicio1 = new Ejercicio1();
            //Ejercicio2 ejercicio2 = new Ejercicio2();
            //Ejercicio3 ejercicio3 = new Ejercicio3();
            //Ejercicio5 ejercicio5 = new Ejercicio5();

            Console.ReadKey();
        }
    }
}
