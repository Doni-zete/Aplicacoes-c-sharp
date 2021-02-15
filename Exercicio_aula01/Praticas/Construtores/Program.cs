using System;


namespace Construtores
{
    class Program
    {
        static void Main()
        {

            Salario s = new Salario();

            Console.WriteLine(s.valor);
            Console.WriteLine(s.mes);
        }
    }

    class Salario
    {
        public double valor;
        public int mes;
        public Salario(double valor, double bonus)
        {
            Console.WriteLine("Criando objeto");

            this.valor = valor + valor * bonus;

        }
        public void MostrarValor()
        {
            Console.WriteLine(valor);
        }
    }



}
