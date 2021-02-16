using System;


namespace StaticCtor
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Cambio.cotacaoDolar);
            Console.WriteLine(Cambio.cotacaoDolar);

        }
    }

    class Cambio
    {
        public static double cotacaoDolar;
        static Cambio()
        {

            Console.WriteLine(Cambio.cotacaoDolar);
            cotacaoDolar = 2.1;
          

        }

    }
}
