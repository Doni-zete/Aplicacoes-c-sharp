using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Selo s = new Selo();
            ImprimirColecao(s);

            Bones b = new Bones();
            ImprimirColecao(b);
        }

        static void ImprimirColecao(IColecionavel c)
        {
            Console.WriteLine("Esta é uma colecão de " + c.GetNomeColecao());
        }
    }
    public interface IColecionavel
    {
        string GetNomeColecao();
    }
    public class Selo : IColecionavel
    {
        public string GetNomeColecao()
        {
            return "selos";
        }
    }

    public class Bones : IColecionavel
    {
        public string GetNomeColecao()
        {
            return "Bones";
        }
    }

}
