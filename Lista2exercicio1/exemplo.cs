using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2exercicio1
{
    class exemplo
    {
        static void Main2(string[] args)
        {
            string nome = "Francisco";
            int QuantidadeDeCasa = 2;
            double Valorcasas = 500000.00;
            int idade = 23;

            Console.WriteLine(nome + "Possuie" + QuantidadeDeCasa + "Casa no valor de R$ " + Valorcasas + "e tem somente" + idade + "anos.");
            // Jeito melhor na parte de baixo

            Console.WriteLine("\n\n");

            Console.WriteLine(string.Format("{0} possuii {1} casas no valor de R$ {2:n} e tem somente {3} anos.", nome, QuantidadeDeCasa, Valorcasas, idade));
        }
    }
}
