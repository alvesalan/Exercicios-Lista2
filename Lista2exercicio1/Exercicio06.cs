using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2exercicio1
{
    class Exercicio06
    {
        public Exercicio06()
        {
            Console.WriteLine("Me diga um numero: ");
            int Numero = Convert.ToInt32(Console.ReadLine());

            if (Numero == 1)
            {
                Console.WriteLine("O numero e igual a 1");
            }
            else
            {
                Console.WriteLine("O numero e diferente de 1");
            }

            Console.ReadKey();
        }
    }
}
