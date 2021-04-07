using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Program
    {
        static void Main()
        {

            Cachorro c = new Cachorro();
            c.Falar();

            Gato g = new Gato();
            g.Falar();

        }
    }
    public class Animal
    {
        public virtual void Falar()
        {
            Console.WriteLine("---");
        }
    }

    public class Cachorro : Animal
    {
        public override void Falar()
        {
            Console.WriteLine("AU-AU");
        }
    }




    public class Gato : Animal


    public override void Falar()
    {
        Console.WriteLine("MIAU");
    }
}
