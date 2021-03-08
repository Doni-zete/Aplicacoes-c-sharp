using System;

namespace ExtensionMethod
{
    class Program
    {
        static void Main()
        {
            ContaCorrente c1 = new ContaCorrente(1234, 5656);
            c1.Titular = "Paulo Silva";
            c1.Depositar(200);
            c1.Sacar(50);
        }
    }
}
