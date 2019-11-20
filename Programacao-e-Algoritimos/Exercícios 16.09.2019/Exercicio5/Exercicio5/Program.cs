using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 5
            int num1, num2;
            Console.Write("Olá! Digite um número inteiro para a soma, por favor: ");
            num1 = int.Parse(Console.ReadLine());

            while (num1 <= 0)
            {

                Console.Write("Olá! Digite um número válido para a soma, por favor: ");
                num1 = int.Parse(Console.ReadLine());
            }

            Console.Write("Olá! Digite outro número inteiro para a soma, por favor: ");
            num2 = int.Parse(Console.ReadLine());
            num1 = num1 + num2;

            while (num2 > 0)
            {
                Console.Write("Olá! Digite outro número inteiro para a soma, por favor: ");
                num2 = int.Parse(Console.ReadLine());
                num1 = num1 + num2;
            }

            Console.WriteLine("\nO resultado da soma é " +num1);
            Console.ReadKey();
        }
    }
}
