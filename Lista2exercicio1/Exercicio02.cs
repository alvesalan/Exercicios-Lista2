using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2exercicio1
{
    class Exercicio02
    {
        public Exercicio02()

        {
            Console.WriteLine("Digite um numero: ");
            int Numero = Convert.ToInt32(Console.ReadLine());

            if (Numero == 0)
            {
                Console.WriteLine("O numero e neutro");

            }
            else if (Numero >= 1)
            {
                Console.WriteLine("O numero não e negativo");
            }
            else if (Numero <= -1)
            {
                Console.WriteLine("O numero e negativo");
            }
            Console.ReadKey();
        }
    }
}
