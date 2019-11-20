using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 6

            int cont, fatorial;
            Console.Write("Digite um número para descobrir o seu Fatorial: ");
            cont = int.Parse(Console.ReadLine());
            fatorial = cont;

            for (int i = cont - 1; i > 1; i--)
            {
                fatorial *= i;
            }

            Console.WriteLine("\nValor total do fatorial é: " + fatorial);
            Console.ReadKey();
        }
    }
}
