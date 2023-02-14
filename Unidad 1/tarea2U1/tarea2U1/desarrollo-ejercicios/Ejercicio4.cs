using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea2U1.desarrollo_ejercicios
{
    internal class Ejercicio4
    {
        public Ejercicio4()
        {
            int num;
            string linea;
            Console.WriteLine();
            Console.WriteLine("****DIAS DE LA SEMANA****\n");
            Console.Write("Ingrese un numero del 1 al 7 :");
            linea = Console.ReadLine();
            num = int.Parse(linea);

            switch (num)
            {
                case 1:
                    Console.WriteLine("DOMINGO");
                    break;
                case 2:
                    Console.WriteLine("LUNES");
                    break;
                case 3:
                    Console.WriteLine("MARTES");
                    break;
                case 4:
                    Console.WriteLine("MIERCOLES");
                    break;
                case 5:
                    Console.WriteLine("JUEVES");
                    break;
                case 6:
                    Console.WriteLine("VIERNES");
                    break;
                case 7:
                    Console.WriteLine("SABADO");
                    break;
            }
        }
    }
}
