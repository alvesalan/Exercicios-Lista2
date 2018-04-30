using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2exercicio1
{
    class Exercicio03
    {
        public Exercicio03()
        {
            Console.WriteLine("Me diga um numero: ");
            double Numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Me diga outro numero: ");            
            double Numero2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine( "  ____________________________   ");
            Console.WriteLine( " | 1  |          Somar        |  ");
            Console.WriteLine( " | 2  |          Subtrair     |  ");
            Console.WriteLine( " | 3  |          Multiplicar  | ");
            Console.WriteLine( " | 4  |          Dividir      | ");
            Console.WriteLine( " |____|_______________________| ");
            double RespostaTabela = Convert.ToDouble(Console.ReadLine());

            if (RespostaTabela == 1)
            {
                Console.WriteLine("soma dos numeros é: " + (Numero1 + Numero2));

            }
            else if (RespostaTabela == 2)
            {
                Console.WriteLine("Subtração dos numero é: " + (Numero1 - Numero2));
            }
            else if (RespostaTabela == 3)
            { 
                Console.WriteLine("A multiplicação dos numero é: " + (Numero1 * Numero2));
            }
            else if (RespostaTabela == 4)
            { 
                Console.WriteLine("A divisão dos numero é: " + (Numero1 / Numero2));
            } 
            else {
                Console.WriteLine("O numero é invalido");
            }

            Console.ReadKey();
           
        }
    }
}
