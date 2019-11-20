using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayaula
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string[] time = new string[] { "a", "b", "c" };
            int[] j = new int[] { 1, 2, 3, 4, 5 };
            int[] l = new int[5];
            l[0] = 1;*/

            Random aleat = new Random();
            //Objeto para criar um número aleatório
            int x, i;
            //Declaração das váriaveis
            Console.Write("Digite o tamanho do vetor: ");
            x = int.Parse(Console.ReadLine());
            int[] num = new int[x];
            //Vetor com o número inserido pelo usuário
            for (i = 0; i < num.Length; i++)
            {
                num[i] = aleat.Next(100, 1000);
            }

            i = 0;

            Array.Sort(num); //Ordena os Array's

            while (i < num.Length)
            {
                Console.Write(num[i] + " ");
                i++;
            }

            Console.WriteLine("\n\n");
            Array.Reverse(num); //Inverte a ordem dos Array's

            foreach (int numero in num)
            {
                Console.Write(numero + " ");
            }

            Console.ReadKey();
        }
    }
}
