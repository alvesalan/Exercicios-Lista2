using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2exercicio1
{
    internal class Exercicio15
    {
        public Exercicio15()
        {
            int ter = 0, seg = 0, pri = 0;


            Console.WriteLine("Diga um numero: ");
            int N1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Outro numero: ");
            int N2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Outro numero: ");
            int N3 = Convert.ToInt32(Console.ReadLine());

            if (N3 > N1 && N3 > N2)
            {
                ter = N3;
            }

            else if ((N2 > N1) && (N2 > N3))
            {
                ter = N2;
            }

            else if ((N1 > N2) && (N1 > N3))
            {
                ter = N1;
            }
            if ((N3 < N1 && N3 < N2))
            {
                pri = N3;
            }

            else if ((N2 < N1) && (N2 < N3))
            {
                pri = N2;
            }

            else if ((N1 < N2) && (N1 < N3))
            {
                pri = N1;
            }


            if (N3 > N1 && N3 < N2)
            {
                seg = N3;
            }

            else if ((N2 > N1) && (N2 < N3))
            {
                seg = N2;
            }

            else if ((N1 > N2) && (N1 < N3))
            {
                seg = N1;
            }
            else if ((N3 < N1 && N3 > N2))
            {
                seg = N3;
            }

            else if ((N2 < N1) && (N2 > N3))
            {
                seg = N2;
            }

            else if ((N1 < N2) && (N1 > N3))
            {
                seg = N1;
            }

            Console.WriteLine("Primeiro Numero: " + ter);
            Console.WriteLine("Segundo Numero:" + seg);
            Console.WriteLine("Terceiro Numero: " + pri);




            Console.ReadKey();
        }
    }
}