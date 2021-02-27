using System;


namespace Proprierties.Endereco
{
    class Program
    {
        static void Main()
        {

            Endereco e = new Endereco();
            e.Logradouro = "R. dos Programadores";
            e.Numero = 250;
            e.Apartamento = true;

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
                if (value != null)
                {
                    logradouro = value;
                }
            }
        }
            

             public int Numero
        {
            get
            {
                return numero;
            }
            set
            {
                numero = value;
            }
        }
        public bool Apartamento
        {
            get
            {
                return apartamento;
            }
            set
            {
                apartamento = value;
            }
        }

    }

}

