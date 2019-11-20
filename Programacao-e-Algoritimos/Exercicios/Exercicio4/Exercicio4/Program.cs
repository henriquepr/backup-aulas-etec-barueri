using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, quociente, resto;
            Console.Write("Digite um número para ser o dividendo: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite um número para ser o divisor: ");
            num2 = int.Parse(Console.ReadLine());
            if (num2 == 0)
            {
                Console.Write("Não existe divisão por zero");
            }
            else
            {
                quociente = num1 / num2;
                resto = num1 % num2;
                Console.Write("\nO quociente é= " + quociente + " e o resto é= " + resto);
            }
            Console.ReadKey();
        }
    }
}
