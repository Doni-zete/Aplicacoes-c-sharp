using System;


namespace tresNotas
{
    class Program
    {

        static void Main()
        {
            //Nota1
            Console.WriteLine("nota1");
            double  nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("peso1");
            double peso1 = double.Parse(Console.ReadLine());

            //Nota2
            Console.WriteLine("nota2");
            double nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("peso2");
            double peso2 = double.Parse(Console.ReadLine());
            //3
            Console.WriteLine("nota3");
            double nota3 = double.Parse(Console.ReadLine());
            Console.WriteLine("peso3");
            double peso3 = double.Parse(Console.ReadLine());


            double media = (nota1 * peso1 + nota2 * peso2 + nota3 * peso3);
                
            Console.WriteLine("A media do aluno e " + media );












        }
    }
}

