using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2exercicio1
{
    class Exercicio01
    {
        public Exercicio01()
        {
            Console.WriteLine("Diga um numero: ");

            double Numero = Convert.ToDouble(Console.ReadLine());

            if (Numero == 0)
            {
                Console.WriteLine("O numero e neutro");
            }
            else if (Numero >= 1)
            {
                Console.WriteLine("O numero e positivo");
            }
            else if (Numero <= -1)
            {
                Console.WriteLine("Numero não e positivo");
            }
            else
            {
                Console.WriteLine("Coloque um numero válido");
            }

           

            Console.ReadKey();
        }
    }
}
