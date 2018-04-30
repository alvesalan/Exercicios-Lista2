using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2exercicio1
{
    class Exercicio09
    {
        public Exercicio09()
        {

            Console.WriteLine("Diga um numero: ");
            double Numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Diga um numero: ");
            double Numero2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Diga um numero:");
            double Numero3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Diga um numero: ");
            double Numero4 = Convert.ToDouble(Console.ReadLine());

            
            if ((Numero1 ==  Numero2) && (Numero1 == Numero3) && (Numero1 == Numero4))
            {
                Console.WriteLine("Pode ser um quadrado");
            }
            else if ((Numero2 == Numero1) && (Numero2 == Numero3) && (Numero2 == Numero4))
            {
                Console.WriteLine("Pode ser um quadrado");
            }
            else if ((Numero3 == Numero1) && (Numero3 == Numero2) && (Numero3 == Numero4))
            {
                Console.WriteLine("Pode ser um quadrado");
            }


            else if ((Numero4 == Numero1) && (Numero4 == Numero2) && (Numero4 == Numero3))
            {
                Console.WriteLine("Pode ser um quadrado");
            }
            else
            {
                Console.WriteLine("Não pode ser um quadrado");
            }

            Console.ReadKey();
            Console.ReadKey();
        }

        }
    }

