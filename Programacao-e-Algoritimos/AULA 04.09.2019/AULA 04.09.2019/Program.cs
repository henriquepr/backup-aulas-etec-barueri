using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULA_04._09._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("<---- Quitanda da ETEC ---->");
            Console.WriteLine("Digite a opção desejada: ");
            Console.WriteLine("1 - Chuchu");
            Console.WriteLine("2 - Repolho");
            Console.WriteLine("3 - Quiabo");
            Console.WriteLine("4 - Laranja");
            Console.WriteLine("5 - Beterraba");
            Console.WriteLine("");

            int escolha = int.Parse(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                    Console.WriteLine("Você escolheu Chuchu");
                    break;
                case 2:
                    Console.WriteLine("Você escolheu Repolho");
                    break;
                case 3:
                    Console.WriteLine("Você escolheu Quiabo");
                    break;
                case 4:
                    Console.WriteLine("Você escolheu Laranja");
                    break;
                case 5:
                    Console.WriteLine("Você escolheu Beterraba");
                    break;
                default:
                    Console.WriteLine("Escolha uma opção válida, otário");
                    break;
            }*/

            Console.WriteLine("<---- Quitanda da ETEC ---->");
            Console.WriteLine("Digite a opção desejada: ");
            Console.WriteLine("1 - Chuchu");
            Console.WriteLine("2 - Repolho");
            Console.WriteLine("3 - Quiabo");
            Console.WriteLine("4 - Laranja");
            Console.WriteLine("5 - Beterraba");
            Console.WriteLine("");

            string escolha = Console.ReadLine();
            switch (escolha.ToLower())
            {
                case "1":
                case "chuchu":
                    Console.WriteLine("Você escolheu Chuchu");
                    break;
                case "2":
                case "repolho":
                    Console.WriteLine("Você escolheu Repolho");
                    break;
                case "3":
                case "quiabo":
                    Console.WriteLine("Você escolheu Quiabo");
                    break;
                case "4":
                case "laranja":
                    Console.WriteLine("Você escolheu Laranja");
                    break;
                case "5":
                case "beterraba":
                    Console.WriteLine("Você escolheu Beterraba");
                    break;
                default:
                    Console.WriteLine("Escolha uma opção válida, otário");
                    break;
            }

            Console.ReadKey();
        }
    }
}
