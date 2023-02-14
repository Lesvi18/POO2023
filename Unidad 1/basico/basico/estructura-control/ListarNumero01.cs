using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.estructura_control
{
    internal class ListarNumero01
    {
        public ListarNumero01()
        {
            /*
             * while(condi){...}
             */


            Console.WriteLine("Listar numero hasta: ");
            int limite = int.Parse(Console.ReadLine());
            int i = 1;
            char continuar = 'c';   

            while (i <= limite && continuar == 'c')
            {
                Console.WriteLine(i);
                i++; // se ejecuta luego de la iteracion
                     //++i; se ejecuta antes de la iteracion
                     //i = i + 1;
                     //i--;, --i;, i = i - 1;

            }

            Console.WriteLine("Desea continuar?");
        }
    }
}
