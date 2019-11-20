using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Teste_Do_While
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int x;
            do
            {
                Console.WriteLine("Insira um valor FDP");
                x = int.Parse(Console.ReadLine());
            } while (x < 0);

            Console.WriteLine(x);*/

            for (int hora = 0; hora < 24; hora++)
            {
                for(int min = 0; min < 60; min++)
                {
                    for(int sec = 0; sec < 60; sec++)
                    {
                        Console.WriteLine(hora + ":" + min + ":" + sec);
                        /*Thread.Sleep(500);*/
                        Console.Clear();
                    }
                }
            }

            Console.ReadKey();
        }
    }
}

