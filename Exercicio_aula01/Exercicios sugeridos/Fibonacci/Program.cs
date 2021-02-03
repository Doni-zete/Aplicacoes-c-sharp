using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main()

        {
            int j = 1;

            for (int i = 0, cont = 0; cont < 15; cont++)
            {
                Console.WriteLine(i);
                i = i + j;
                j = i - j;
            }

        }
    }

}

