using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2exercicio1
{
    class Exercicio08
    {
        public Exercicio08()
        {
            

            Console.WriteLine("     Tipo                  Nome                                              Valor");

            Console.WriteLine("1-   Bolos                 bolo brigadeiro                                   R$ 29,50");
            Console.WriteLine("2-   Bolos                 bolo floresta negra                               R$ 2,00");
            Console.WriteLine("3-   Bolos                 bolo leite com nutella                            R$ 29,23");
            Console.WriteLine("4-   Bolos                 bolo mousse com chocolate                         R$ 7,10");
            Console.WriteLine("5-   Bolos                 bolo nega Maluca                                  R$ 19,33");

            Console.WriteLine("6-   Doces                 bomba de creme                                    R$ 17,71");
            Console.WriteLine("7-   Doces                 bomba de morango                                  R$ 4,82");

            Console.WriteLine("8-   Sanduiches            file-Mignon com fritas e chedar                   R$ 21,16");
            Console.WriteLine("9-   Sanduiches            hamburguer com queijos, champignon e rúcula       R$ 12,70");
            Console.WriteLine("10-  Sanduiches            provolome com salame                              R$ 19,70");
            Console.WriteLine("11   Sanduiches            vegetariano de berinjela                          R$ 28,22");

            Console.WriteLine("12-  Pizzas                calabresa                                         R$ 8,98");
            Console.WriteLine("13-  Pizzas                napolitana                                        R$ 0,42");
            Console.WriteLine("14-  Pizzas                peruana                                           R$ 18,36");
            Console.WriteLine("15-  Pizzas                portuguesa                                        R$ 27,50");


            
            Console.WriteLine("Digite o Numero do pedido: ");
            int Opçao1 = Convert.ToInt32(Console.ReadLine());

            double Valor = 0;

            if (Opçao1 == 1)
            {
                Valor = 29.50;
            }
            else if (Opçao1 == 2)
            {
                Valor = 2.00;
            }
            else if (Opçao1 == 3)
            {
                Valor = 29.23;
            }
            else if (Opçao1 == 4)
            {
                Valor = 7.10;
            }
            else if (Opçao1 == 5)
            {
                Valor = 19.33;
            }
            else if (Opçao1 == 6)
            {
                Valor = 17.71;
            }
            else if (Opçao1 == 7)
            {
                Valor = 4.82;
            }
            else if (Opçao1 == 8)
            {
                Valor = 21.16;
            }
            else if (Opçao1 == 9)
            {
                Valor = 12.70;
            }
            else if (Opçao1 == 10)
            {
                Valor = 19.70;
            }
            else if (Opçao1 == 11)
            {
                Valor = 28.22;
            }
            else if (Opçao1 == 12)
            {
                Valor = 8.98;
            }
            else if (Opçao1 == 13)
            {
                Valor = 0.42;
            }
            else if (Opçao1 == 14)
            {
                Valor = 18.36;
            }
            else if (Opçao1 == 15)
            {
                Valor = 27.50;
            }

            Console.Clear();
            Console.WriteLine("     Tipo                  Nome                                              Valor");

            Console.WriteLine("1-   Bolos                 bolo brigadeiro                                   R$ 29,50");
            Console.WriteLine("2-   Bolos                 bolo floresta negra                               R$ 2,00");
            Console.WriteLine("3-   Bolos                 bolo leite com nutella                            R$ 29,23");
            Console.WriteLine("4-   Bolos                 bolo mousse com chocolate                         R$ 7,10");
            Console.WriteLine("5-   Bolos                 bolo nega Maluca                                  R$ 19,33");

            Console.WriteLine("6-   Doces                 bomba de creme                                    R$ 17,71");
            Console.WriteLine("7-   Doces                 bomba de morango                                  R$ 4,82");

            Console.WriteLine("8-   Sanduiches            file-Mignon com fritas e chedar                   R$ 21,16");
            Console.WriteLine("9-   Sanduiches            hamburguer com queijos, champignon e rúcula       R$ 12,70");
            Console.WriteLine("10-  Sanduiches            provolome com salame                              R$ 19,70");
            Console.WriteLine("11   Sanduiches            vegetariano de berinjela                          R$ 28,22");

            Console.WriteLine("12-  Pizzas                calabresa                                         R$ 8,98");
            Console.WriteLine("13-  Pizzas                napolitana                                        R$ 0,42");
            Console.WriteLine("14-  Pizzas                peruana                                           R$ 18,36");
            Console.WriteLine("15-  Pizzas                portuguesa                                        R$ 27,50");

            Console.WriteLine("Escolha sua 2° opçao");
            double Opçao2 = Convert.ToDouble(Console.ReadLine());
            

            double Valor2 = 0;

            if (Opçao2 == 1)
            {
                Valor2 = 29.50;
            }
            else if (Opçao2 == 2)
            {
                Valor2 = 2.00;
            }
            else if (Opçao2 == 3)
            {
                Valor2 = 29.23;
            }
            else if (Opçao2 == 4)
            {
                Valor2 = 7.10;
            }
            else if (Opçao2 == 5)
            {
                Valor2 = 19.33;
            }
            else if (Opçao2 == 6)
            {
                Valor2 = 17.71;
            }
            else if (Opçao2 == 7)
            {
                Valor2 = 4.82;
            }
            else if (Opçao2 == 8)
            {
                Valor2 = 21.16;
            }
            else if (Opçao2 == 9)
            {
                Valor2 = 12.70;
            }
            else if (Opçao2 == 10)
            {
                Valor2 = 19.70;
            }
            else if (Opçao2 == 11)
            {
                Valor2 = 28.22;
            }
            else if (Opçao2 == 12)
            {
                Valor2 = 8.98;
            }
            else if (Opçao2 == 13)
            {
                Valor2 = 0.42;
            }
            else if (Opçao2 == 14)
            {
                Valor2 = 18.36;
            }
            else if (Opçao2 == 15)
            {
                Valor2 = 27.50;
            }


            Console.Clear();

            Console.WriteLine("Tipo                  Nome                                              Valor");

            Console.WriteLine("1-   Bolos                 bolo brigadeiro                                   R$ 29,50");
            Console.WriteLine("2-   Bolos                 bolo floresta negra                               R$ 2,00");
            Console.WriteLine("3-   Bolos                 bolo leite com nutella                            R$ 29,23");
            Console.WriteLine("4-   Bolos                 bolo mousse com chocolate                         R$ 7,10");
            Console.WriteLine("5-   Bolos                 bolo nega Maluca                                  R$ 19,33");

            Console.WriteLine("6-   Doces                 bomba de creme                                    R$ 17,71");
            Console.WriteLine("7-   Doces                 bomba de morango                                  R$ 4,82");

            Console.WriteLine("8-   Sanduiches            file-Mignon com fritas e chedar                   R$ 21,16");
            Console.WriteLine("9-   Sanduiches            hamburguer com queijos, champignon e rúcula       R$ 12,70");
            Console.WriteLine("10-  Sanduiches            provolome com salame                              R$ 19,70");
            Console.WriteLine("11   Sanduiches            vegetariano de berinjela                          R$ 28,22");

            Console.WriteLine("12-  Pizzas                calabresa                                         R$ 8,98");
            Console.WriteLine("13-  Pizzas                napolitana                                        R$ 0,42");
            Console.WriteLine("14-  Pizzas                peruana                                           R$ 18,36");
            Console.WriteLine("15-  Pizzas                portuguesa                                        R$ 27,50");

            Console.WriteLine("Escolha sua 3° opçao");
            int Opçao3 = Convert.ToInt32(Console.ReadLine());

            double Valor3 = 0;

            if (Opçao3 == 1)
            {
                Valor3 = 29.50;
            }
            else if (Opçao3 == 2)
            {
                Valor3 = 2.00;
            }
            else if (Opçao3 == 3)
            {
                Valor3 = 29.23;
            }
            else if (Opçao3 == 4)
            {
                Valor3 = 7.10;
            }
            else if (Opçao3 == 5)
            {
                Valor3 = 19.33;
            }
            else if (Opçao3 == 6)
            {
                Valor3 = 17.71;
            }
            else if (Opçao3 == 7)
            {
                Valor3 = 4.82;
            }
            else if (Opçao3 == 8)
            {
                Valor3 = 21.16;
            }
            else if (Opçao3 == 9)
            {
                Valor3 = 12.70;
            }
            else if (Opçao3 == 10)
            {
                Valor3 = 19.70;
            }
            else if (Opçao3 == 11)
            {
                Valor3 = 28.22;
            }
            else if (Opçao3 == 12)
            {
                Valor3 = 8.98;
            }
            else if (Opçao3 == 13)
            {
                Valor3 = 0.42;
            }
            else if (Opçao3 == 14)
            {
                Valor3 = 18.36;
            }
            else if (Opçao3 == 15)
            {
                Valor3 = 27.50;
            }
            Console.Clear();
            Console.WriteLine("Opção 1: " + Opçao1 +   "  Valor: R$ " + Valor);
            Console.WriteLine("Opção 2: " + Opçao2 +   "  Valor: R$ " + Valor2);
            Console.WriteLine("Opção 3: " + Opçao3 +   "  Valor: R$ " + Valor3);

            Console.WriteLine("Valor total: " + (Valor + Valor2 + Valor3));
            Console.ReadKey();







        }
    }
}
