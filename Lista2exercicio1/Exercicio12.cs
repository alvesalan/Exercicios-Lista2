using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2exercicio1
{
    class Exercicio12
    {
        public Exercicio12()
        {
            Console.WriteLine("Me diga um numero: ");
            int N1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Outro numero: ");
            int N2 = Convert.ToInt32(Console.ReadLine());

            if (N1 > N2)
            {
                Console.WriteLine("1° Numero e o maior");
            }
            else if (N2 > N1)
            {
                Console.WriteLine("2° Numero e o maior");
            }
            else if (N1 == N2)
            {
                Console.WriteLine("os numeros são iguais");
            }


            Console.ReadKey();
        }
    }
}