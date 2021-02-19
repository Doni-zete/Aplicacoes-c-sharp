using System;


namespace Constants
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Matematica.PI);
            Console.WriteLine(Matematica.E);
        }
    }
    class Matematica
    { 
        public const double PI = 3.1416;
       
        public static readonly double E;
    }
}