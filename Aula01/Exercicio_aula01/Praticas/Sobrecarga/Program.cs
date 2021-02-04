using System;


namespace Sobrecarga
{
    class Program
    {
        static void Main()
        {
            Matematica m = new Matematica();
            int r1 = m.Somar(10,6,5);
            Console.WriteLine(r1);

        }
    }

    class Matematica
    {
        public int Somar (int a, int b)
        {
            Console.Write("[int, int]");

            return a + b;
        }

        public int Somar(int a, int b, int c)
        {
            Console.Write("[int, int,int]");

            return a + b+ c;
        }


        public double Somar(double a, double b)
        {
            return a + b;
        }
        public long Somar (long a, long b)
        {
            Console.WriteLine("[long,long]");
            return a + b;
        }
    }
}
