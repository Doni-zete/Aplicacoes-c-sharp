﻿using System;


namespace Parametros1
{
    class Program
    {
        static void Main()
        {
            Myclass m = new Myclass();
            int i = 5;
            m.Trocar(ref i);

            Console.WriteLine(i);
            Numero num =  new Numero();
            num.n =5;
            m.mudar (num);

            Console.WriteLine(num.n);
        }
    }

    class MyClass
    {
        public void Trocar(ref int x)
        {
            x = 10;
        }
        public void Mudar (ref Numero x)
            {
           // x.n =10;
           x =new Numero();
            x.n =20;
        }
    }

    class Numero
	{
        public int n;
	}
}
