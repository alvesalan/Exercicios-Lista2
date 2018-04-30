 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2exercicio1
{
    internal class Exercicio19
    {
        public Exercicio19()
        {
            Console.WriteLine("Qual o seu saldo: ");
            double Saldo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Valor dos depositos: ");
            double ValorDepositos = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("valor das parcelas de emprestimos: ");
            double ParcelaEmprestimo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Valor dos saques: ");
            double ValorDosSaques = Convert.ToDouble(Console.ReadLine());

            double SaldoTotal = Saldo - (ValorDepositos + ParcelaEmprestimo + ValorDosSaques);

            if (SaldoTotal == 0)
            {
                Console.WriteLine("Seu saldo e neutro: (0,00 R$)");
            }
            else if (SaldoTotal < 0)
            {
                Console.WriteLine("Saldo negativo: " + SaldoTotal + "R$");
            }
            else if (SaldoTotal > 0)
            {
                Console.WriteLine("Saldo Positivo: " + SaldoTotal  + "R$");
            }

            Console.ReadKey();

            // zero saldo neutro, maior que zero saldo positivo, menor que zero saldo negativo
        }
    }
}