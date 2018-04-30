using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2exercicio1
{
    class Exercicio05
    {
        public Exercicio05()
        {
            Console.WriteLine("Me diga um numero: ");
            int Numero = Convert.ToInt32(Console.ReadLine());

            if (Numero == 0)
            {
                Console.WriteLine("O numero e neutro");
            }
            else if (Numero % 2 == 1)
            {
                Console.WriteLine("o numero e impar");

            }
            else if (Numero % 2 == 0)
            {
                Console.WriteLine("O numero não e impar");
            }

            Console.ReadKey();
        }
    }
}
