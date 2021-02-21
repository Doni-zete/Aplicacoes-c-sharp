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
            q.lado = 3.2;
            area = q.CalcularArea();
            Console.WriteLine("Area quadrado: " + area);

            Circunferencia c =new  Circunferencia();
            c. raio = 5;
            area = c.CalcularArea();
            Console.WriteLine("Area da circunferencia: " + area);



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

    class Circunferencia
    {
        public double raio;
        public double CalcularArea()
        {
            double  area= Math.PI  * raio * raio;
            return area;
        }

    }

    }
    


    