using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen1.examenUnidad1
{
    internal class Ejercicio5
    {
        public Ejercicio5()
        {

            bool continuar = true;
            Console.WriteLine("DESEA CONTINUAR? SI/NO");
            int eleccion = int.Parse(Console.ReadLine());

            while (continuar)
            {
                eleccion = 'S';
            } 
            {
                eleccion = 'N';
            }
      
        }
    }
}
