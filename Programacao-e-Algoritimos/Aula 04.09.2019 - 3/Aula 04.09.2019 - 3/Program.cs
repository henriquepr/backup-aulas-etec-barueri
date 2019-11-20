using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_04._09._2019___3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Digite o número inicial, sendo menor que o número final: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o número final: ");
            num2 = int.Parse(Console.ReadLine());
            while (num1 >= num2)
            {
                Console.Write("\nPara de ser burro, digite o número inicial menor que o número final: ");
                num1 = int.Parse(Console.ReadLine());
                Console.Write("Digite novamente o número final: ");
                num2 = int.Parse(Console.ReadLine());
            }

            while (num1<=num2)
            {
                if(num1 % 2 == 0)
                {
                    Console.Write(num1 + ", ");
                }
                num1++;
            }

            Console.ReadKey();
        }
    }
}
