using System;


namespace Heranca
{
    class Program
    {
       

        static void Main()
        {
            Animal a = new Animal();
            a.Peso = 4;
            a.Altura = 0.8;

            a.Mover();
            a.MostrarDados();


        }
     
    }
}
