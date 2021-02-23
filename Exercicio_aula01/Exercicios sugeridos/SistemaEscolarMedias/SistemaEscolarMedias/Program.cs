using System;

namespace SistemaEscolarMedias
{
    class Program
    {
        static void Main()
        {
            aluno1 a1 = new aluno1();
            a1.notaParte1 = 4.0;
            a1.notaParte2 = 2.5;
            a1.notaParte3 = 1.0;
            a1.notaParte4 = 7.0;
            double notaMA1 = a1.CalcularMediaAluno();
            Console.WriteLine("A nota do aluno 1 e: " + notaMA1);

            mediaTurma m = new mediaTurma();
            m.notamediaturma = notaMA1;
            double notaMedTurmaa1 = m.CalcularMediaTurma();
            Console.WriteLine("A media da turma e: " + notaMedTurmaa1);

            NotaTotal t = new NotaTotal();
            t Notastotais =

        }


        class aluno1
        {
            public double notaParte1;
            public double notaParte2;
            public double notaParte3;
            public double notaParte4;
            public double CalcularMediaAluno()
            {
                double notaMA1 = (notaParte1 + notaParte2 + notaParte3 + notaParte4) / 4;
                return notaMA1;
            }

        }
            class mediaTurma
        {
            public double notamediaturma;
            public double CalcularMediaTurma()
            {
                double notaMedTurmaa1 = (notamediaturma + notamediaturma) / 2;
                return notaMedTurmaa1;
            }

        }
    }
}