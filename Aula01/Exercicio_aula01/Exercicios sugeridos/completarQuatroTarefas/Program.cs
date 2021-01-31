using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace completarQuatroTarefas
{
    class Program
    {
        static void Main(string[] args)
        {

            // Tarefa 1 do 10 ao 25
            for (int i = 10; i < 26; i++)
            {
                Console.WriteLine(i);
            }

            // tarefa 2 pular  de 2  em 2 
            Console.WriteLine("");
            Console.WriteLine("");
            int soma = 0;
            for (int i = 1; i <= 100; i += 2) 
            {
                soma += i;
            }
            Console.WriteLine(soma);

            int soma1 = 0; int numero = 0;

           while(soma1 <=100)

            {
                Console.WriteLine(numero);
                soma1 += numero;
                numero++;
            }

            Console.WriteLine(numero);
            Console.WriteLine(numero);
            for (int i = 0;  i<= 10; i++)
            {
                Console.WriteLine("9 x" + i+  "= "+i*9);
            }




        }
    }
}
