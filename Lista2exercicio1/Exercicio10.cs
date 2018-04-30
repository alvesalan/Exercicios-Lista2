using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2exercicio1
{
    class exercicio10
    {
        public exercicio10()
        {
            Console.WriteLine("     __________________");
            Console.WriteLine("     |                |");
            Console.WriteLine("     |                |");
            Console.WriteLine("     |________________|");

            Console.WriteLine("1° Número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2° Número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("3° Número: ");
            int numero3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("4° Número: ");
            int numero4 = Convert.ToInt32(Console.ReadLine());

            if ((numero1 != numero4) && (numero2 != numero3))
            {
                Console.WriteLine("Pode ser um retangulo");
            }
            else if ((numero1 == numero4) && (numero2 == numero3))
            {
                Console.WriteLine("SEU BURRO VAI ESTUDAR SEU MERDA");
            }

            
            Console.ReadKey();
        }
    }
}
