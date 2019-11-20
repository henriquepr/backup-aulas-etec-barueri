using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_04._09._2019___Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<---- Cantina da ETEC ---->");
            Console.WriteLine("1 - X-tega --- R$ 2,00");
            Console.WriteLine("2 - X-calabresa --- R$ 5,00");
            Console.WriteLine("3 - Coxinha --- R$ 3,50");
            Console.WriteLine("4 - Pao na Chapa --- R$ 4,80");
            Console.WriteLine("5 - X-Ovo Frito --- R$ 7,00");

            int escolha = int.Parse(Console.ReadLine());

            switch (escolha.ToLower())
            {
                case 1:
                case "x-tega":
                    Console.ReadLine("Você escolheu um X-tega, pelo valor de R$ 2,00");
                    break;
                case 2:
                case "x-calabresa":
                    Console.ReadLine("Você escolheu um X-calabresa, pelo valor de R$ 5,00");
                    break;
                case 3:
                case "coxinha":
                    Console.ReadLine("Você escolheu uma Coxinha, pelo valor de R$ 3,50");
                    break;
                case 4:
                case "pao na chapa":
                    Console.ReadLine("Você escolheu um Pão na Chapa, pelo valor de R$ 4,80");
                    break;
                case 5:
                case "x-ovo frito":
                    Console.ReadLine("Você escolheu um X-Ovo frito, pelo valor de R$ 7,00");
                    break;

                default:
                    Console.Write("TESTE");
            }
        Console.ReadKey();
        }
    }
}
