using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lista2exercicio1
{
    internal class Exercicio20
    {
        public Exercicio20()
        {
            Console.WriteLine("Digite seu peso: ");
            double Peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite sua altura: ");
            double Altura = Convert.ToDouble(Console.ReadLine());

            double IMC = Peso / (Altura * Altura);

            if (IMC <= 9.99)
            {
                Console.WriteLine("Desnutrição Grau V,  IMC: " + IMC);
            }
            if ((IMC >= 10) && (IMC <= 12.9))
            {
                Console.WriteLine("Desnutrição Grau IV,  IMC: " + IMC);
            }
            if ((IMC >= 13) && (IMC <= 15.9))
            {
                Console.WriteLine("Desnutrição Grau III,  IMC: " + IMC);
            }
            if ((IMC >= 16) && (IMC <= 16.9))
            {
                Console.WriteLine("Desnutrição Grau II,  IMC: " + IMC);
            }
            
            if ((IMC >= 17) && (IMC <= 18.4))
            {
                Console.WriteLine("Desnutrição Grau I,  IMC: " + IMC);
            }
            if ((IMC >= 18.5) && (IMC <= 24.9))
            {
                Console.WriteLine("Normal,  IMC: " + IMC);
            }
            if ((IMC >= 25) && (IMC <= 29.9))
            {
                Console.WriteLine("Pré-Obesidade,  IMC: " + IMC);
            }
            if ((IMC >= 30) && (IMC <= 34.5))
            {
                Console.WriteLine("Obesidade grau I,  IMC: " + IMC);
            }
            if ((IMC >= 34.6) && (IMC <= 39.9))
            {
                Console.WriteLine("Obesidade grau II,  IMC: " + IMC);
            }
            else if (IMC >= 39.9)
            { 
                Console.WriteLine("Obesidade grau III,  IMC: " + IMC);
            }

            Console.ReadKey();
        }
    }
}