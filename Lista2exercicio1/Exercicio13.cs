using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lista2exercicio1
{
    internal class Exercicio13
    {
        public Exercicio13()
        {
            Console.WriteLine("Diga um numero: ");
            int N1 = Convert.ToInt32(Console.ReadLine());
         
            Console.WriteLine("Outro numero: ");
            int N2 = Convert.ToInt32(Console.ReadLine());

            if (N1 < N2)
            {
                Console.WriteLine("O 1° NUMERO E O MENOR");
            }
            else if (N2 < N1)
            {
                Console.WriteLine("O 2° NUMERO E O MENOR");
            }
            else if (N1 == N2)
            {
                Console.WriteLine("Os numeros são iguais");
            }

            Console.ReadKey();
        }
    }
}