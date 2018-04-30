using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2exercicio1
{
    class Exercicio11
    {
        public Exercicio11()
        {
            Console.WriteLine("Nota                  Status");
            Console.WriteLine("De 0 até 5.99         Reprovado");
            Console.WriteLine("De 6.00 até 7.99      Recuperação");
            Console.WriteLine("Acima de 7.99         Aprovado");


            Console.WriteLine("Me diga sua nota N1");
            double Nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Me diga sua nota N2");
            double Nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Me diga sua nota N3");
            double Nota3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Me diga sua nota N4");
            double Nota4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Me diga sua nota N5");
            double Nota5 = Convert.ToDouble(Console.ReadLine());

            double Media = (Nota1 + Nota2 + Nota3 + Nota4 + Nota5)/ 5 ;

            if ((Media > 0) && (Media < 5.99))
            {
                Console.WriteLine("Reprovado");
            }


            else if ((Media > 5.99) && (Media < 7.99))
            {
                Console.WriteLine("Recuperação");
            }
            else if (Media > 7.99)
            {
                Console.WriteLine("Aprovado (Parabens !!)");
            }
            Console.ReadKey();
        }
    }
}
