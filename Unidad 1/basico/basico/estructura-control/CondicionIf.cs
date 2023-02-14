using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.estructura_control
{
    internal class CondicionIf
    {
        public CondicionIf()
        {
            Console.WriteLine("Condicion");
            Console.WriteLine("--------------");

            Console.WriteLine("Ingrese su edad");
            int edad = int.Parse(Console.ReadLine());

            //operadores logicos
            //    ==comparar
            //    > mayor que
            //    < menor que
            //    >= mayor o igual que
            //    <= menor o igual que
            //    != distinto

            //compuertas logicas
            //    && AND o Y
            //    || OR u O
          
            if (edad >= 18)
            {
                Console.WriteLine("Usted es mayor de edad");
            }
            else
            {
                Console.WriteLine("Usted es menor de edad");
            }

            if (edad >= 16 && edad <= 18)
            {
                Console.WriteLine("Puede participar en la seleccion sub-18");
            }
            else
            {
                Console.WriteLine("No puede participar en la seleccion sub-18");
            }
        }
    }
}
