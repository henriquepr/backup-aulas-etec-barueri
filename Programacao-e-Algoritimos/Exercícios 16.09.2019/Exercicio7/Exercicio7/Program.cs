using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {

            //Exercicio 7
            int maior, i, num;
            Console.WriteLine("Digite 10 números para descobrirmos qual o maior entre eles");
            Console.Write("\nDigite o 1º número: ");
            num = int.Parse(Console.ReadLine());
            maior = num;
            i = 1;

            for (i = 2; i <= 10; i++)
            {
                Console.Write("Digite o "+i+"º número: ");
                num = int.Parse(Console.ReadLine());
                if (num > maior)
                {
                    maior = num;
                }
            }

            Console.WriteLine("\nO maior número entre os digitados é: "+maior);

            Console.ReadKey();
        }
    }
}
