using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basico.estructura_control
{
    internal class ListarNumeros05
    {
        public ListarNumeros05()
        {
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next(1, 100));
            }
           
        }
    }
}
