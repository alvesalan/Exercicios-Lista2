using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2exercicio1
{
    class Exercicio07
    {
        public Exercicio07()
        {          
            Console.WriteLine("Me diga um numero: ");
            int Numero = Convert.ToInt32(Console.ReadLine());


            if (Numero == 0)
            {
                Console.WriteLine("O numero e neutro");
            }
            else if (Numero % 2 == 0)
            {
                Console.WriteLine("O numero e par");
            }
            else if (Numero % 2 == 1)
            {
                Console.WriteLine("O numero e impar");
            }


            if (Numero < 0)
            {
                Console.WriteLine("O numero e negativo");
            }
            else if (Numero > 0)
            {
                Console.WriteLine("O numero e positivo");
            } 
            else
            {
                Console.WriteLine("O numero nao e negativo e nem positivo");
            }



            



            if (Numero > 10)
            {
                Console.WriteLine("O numero e maior que (10)");
            }
            else if (Numero < 10)
            {
                Console.WriteLine("O numero não e maior que (10)");
            }
            else if (Numero == 10)
            {
                Console.WriteLine("O numero e exatamente (10)");
            }


           if (Numero == 50)
           {
               Console.WriteLine("O numero = a 50");
           }
           else if (Numero < 50)
           {
               Console.WriteLine("O numero e menor que 50");
           }
           else if (Numero > 50)
            {
                Console.WriteLine("O numero não e menor que 50");
            }


            if (Numero < -10)
            {
                Console.WriteLine("Numero e menor que  -10");
            }
            else if (Numero > -10)
            {
                Console.WriteLine("O numero não e menor que -10");
            }

            if (Numero > 30)
            {
                Console.WriteLine("O numero e maior que 30");
            }
            else if (Numero == 30)
            {
                Console.WriteLine("O numero e = a 30");
            }
            else if (Numero < 30)
            {
                Console.WriteLine("O numero não e maior que 30");
            }
            

            if (Numero != 1)
            {
                Console.WriteLine("Numero e diferente de 1");
            }
            else if (Numero == 1)
            {
                Console.WriteLine("O numero não e diferente de 1");
            }
            Console.ReadKey();
        }
    }
}
