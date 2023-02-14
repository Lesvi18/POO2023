using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea2U1.desarrollo_ejercicios
{
    internal class Ejercicio3
    {
        public Ejercicio3()
        {
            Console.WriteLine("Ingrese el genero: ");
            char genero = char.Parse(Console.ReadLine());
            int masculino = int.Parse(Console.ReadLine());  

            if (genero == masculino)
            {
                Console.WriteLine("Es hombre");
            }
            else
            {
                Console.WriteLine("Es mujer");
            }
        }
    }
}
