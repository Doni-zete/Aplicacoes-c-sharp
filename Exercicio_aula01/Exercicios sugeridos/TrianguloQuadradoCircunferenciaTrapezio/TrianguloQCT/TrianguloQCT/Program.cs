using System;


namespace TrianguloQCT
{
    class Program
    {
        static void Main()
        {

            Triangulo tr = new Triangulo();
            tr.@base = 2.5;
            tr.altura = 4;
            double area = tr.CalcularArea();
            Console.WriteLine("Area do triangulo " + area);

            Quadrado q = new Quadrado();
            q.lado = 3.5;
            area = q.CalcularArea();
            Console.WriteLine("Area do quadrado e " + area);
        }
    }

    class Triangulo
    {
        public double @base;
        public double altura;
        public double CalcularArea()
        {
            double area = @base * altura / 2;
            return area;
        }
        class Quadrado
        {
            public double lado;
            public double CalcularArea()
            {
                double area = lado * lado;
                return area;

            }


        }
    }
}
