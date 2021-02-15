using System;


namespace @static
{
    class Program
    {
        static void Main()
        {
            Bola b1 = new Bola();
            Console.WriteLine(b1.numBolas);
            Bola b2 = new Bola();
            Console.WriteLine(b2.numBolas);
            Bola b3 = new Bola();
            Console.WriteLine(b3.numBolas);
        }
    }
    class Bola
    {
        public int numBolas;
        public Bola()
        {
            numBolas++;
        }



    }
}
