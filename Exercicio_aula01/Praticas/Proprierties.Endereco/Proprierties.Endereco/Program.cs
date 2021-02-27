using System;


namespace Proprierties.Endereco
{
    class Program
    {
        static void Main()
        {

            Endereco e = new Endereco();
            e.Logradouro = "R. dos Programadores";
            e.numero = 250;
            e.apartamento = true;

        }
    }
class Endereco
    {
        private string logradouro;
        private int numero;
        private bool apartamento;

        public string Logradouro
        {
            get
            {
                return logradouro;
            }
            set
            {
                logradouro = value;

            }
        }

    }
}
