using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea2U1.desarrollo_ejercicios
{
    internal class Ejercicio9
    {
        public Ejercicio9()
        {
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("Dese continuar? SI/NO");
                string eleccion = Console.ReadLine().ToUpper();   

                if (eleccion == "SI")
                {
                    continuar = true;
                }
                else
                {
                    continuar = false;
                }
            }
        }
    }
}
