using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.estructura_control
{
    internal class Promedio
    {
        /*
        * menos de 70 puntos reprobado
        * mas de 70 puntos aprobado
        * mas de 80 puntos bueno
        * mas de 90 sobresaliente 
        **/
        public Promedio()
        {
            Console.WriteLine("***INGRESE 3 NOTAS***");
            Console.WriteLine("Ingrese nota 1: ");
            int nota1 = int.Parse(Console.ReadLine());   
            Console.WriteLine("Ingrese nota 2: ");
            int nota2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese nota 3: ");
            int nota3 = int.Parse(Console.ReadLine());

            double sum = nota1 + nota2 + nota3;
            double promedio = sum / 3;

            if (promedio < 70)
            {
                Console.WriteLine("REPROBADO");
            }
            else
            {
                if (promedio > 70)
                {
                    Console.WriteLine("APROBADO");
                }
            }
            if (promedio > 80)
            {
                Console.WriteLine("BUENO");
            }
            if (promedio > 90)
            {
                Console.WriteLine("SOBRESALIENTE");
            }
        }    
    }
}
