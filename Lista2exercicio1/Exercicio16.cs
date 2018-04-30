using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2exercicio1
{
    internal class Exercicio16
    {
        public Exercicio16()
        {


            double x;
           
            Console.WriteLine("Diga a temperatura: ");
            double Temperatura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Opçoes: 1- Celsius, 2- Fahrenhit, 3- Kelvin");
            Console.WriteLine("Escala original: ");
            int EscalaOriginal = Convert.ToInt32(Console.ReadLine());
            


            Console.WriteLine("Opçoes: 1- Celsius, 2- Fahrenhit, 3- Kelvin");
            Console.WriteLine("Temperatura que quer converter: ");
            int EscalaParaConverter = Convert.ToInt32(Console.ReadLine());





            if ((EscalaOriginal == 2) && (EscalaParaConverter == 1))
            {
                x = 5 * (Temperatura - 32) / 9;

                Console.WriteLine("São: " + x + " °C  Convertidos");
            }
            else if ((EscalaOriginal == 1) && (EscalaParaConverter == 2))
            {
                x = (9 * Temperatura) / 5 + 32;

                Console.WriteLine("São " + x + " °F Convertidos");
            }
            else if ((EscalaOriginal == 3) && (EscalaParaConverter == 1))
            {
                x = (Temperatura - 273.15);

                Console.WriteLine("São: " + x +  "°C Convertidos");
            }
            else if ((EscalaOriginal == 1) && (EscalaParaConverter == 3))
            {
                x = Temperatura + 273.15;

                Console.WriteLine("São: " + x + "°K Convertidos");
            }
            else if  ((EscalaOriginal == 2) && (EscalaParaConverter == 3))
            {
                x = 5 * (Temperatura - 32) / 9 + 273.15;

                Console.WriteLine("São: " + x + "°k Convertidos");
            }
            else if ((EscalaOriginal == 3) && (EscalaParaConverter == 2))
            {
                x = 9 * (Temperatura - 273.15) / 5 + 32;

                Console.WriteLine("São: " + x + "°F Convertidos");
            }






            Console.ReadKey();

          //  celsius tc / 5      //fahrenhit tf - 32 / 9     // kelvin tk - 273 / 5  
        }
    }
}