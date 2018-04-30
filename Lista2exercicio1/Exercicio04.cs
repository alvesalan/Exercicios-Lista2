using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2exercicio1
{
    class Exercicio04
    {
        public Exercicio04()
        {
            Console.WriteLine("Me diga um numero: ");
            int Numero = Convert.ToInt32(Console.ReadLine());

            if (Numero == 0)
            {
                Console.WriteLine("o numero e neutro");
            }
            else if (Numero % 2 == 0)
            {
                Console.WriteLine("o numero e par");
            }
            else if (Numero % 2 == 1)
            {
                Console.WriteLine("o numero nao e par");            
            }

            Console.ReadKey();
        }
    }
}
