using System;


namespace Heranca
{
    class Animal
    {
        public double Altura { get; set; }
        public double Peso { get; set; }

        public void Mover()
        {
            Console.WriteLine("Animal se moveu"); 
        }
        public void MostrarDados()
        {
            Console.WriteLine("Altura =" + Altura + "Peso =" + Peso);
        }
    }
}
