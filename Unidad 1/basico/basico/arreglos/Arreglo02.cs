using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.arreglos
{
    internal class Arreglo02
    {
        public Arreglo02()
        {
            bool continuar = true;

            while (continuar)
            {
                Random random = new Random();
                Console.WriteLine("Cuantos numeros desea ingresar? ");
                int num = int.Parse(Console.ReadLine());

                int[] numeros = new int[num];

                for (int i = 0; i < num; i++)
                {
                    numeros[i] = random.Next(1, 100);
                    Console.WriteLine("numeros[" + i + "] = " + numeros[i]);
                }
                Console.WriteLine("Desea continuar? si/no");
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