using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.estructura_control
{
    internal class ListarNumeros03
    {
        public ListarNumeros03()
        {
            Console.WriteLine("Listar numeros hasta: ");
            int limite = int.Parse(Console.ReadLine());
            int i = 1;
            do
            {
                
                Console.WriteLine(i);
                i++;
                    
            } while (i <= limite);
        }
    }
}
