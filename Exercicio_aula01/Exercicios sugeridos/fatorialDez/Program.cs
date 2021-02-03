using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fatorialDez
{
    class Program
    {
        static void Main(string[] args)
        {

            int valor = 0;
            int resposta = 1;
            for (int i = 2; i <= valor; i++)
            {
                resposta *= i;
            }

            Console.WriteLine("O fatorial de " + valor + " é igual a " + resposta);

            static long calcularFatorial(int num)
            {
                if (num == 0)
                {
                    // Para num == 0, o fatorial é 1.
                    return 1;
                }

                // Caso contrário, o fatorial é o número multiplicado pelo fatorial do seu antecessor.
                return num * calcularFatorial(num - 1);
            }
        }
    }
}