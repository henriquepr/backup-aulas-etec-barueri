using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Exercício1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 1
            int cont;
            for(cont=1000; cont>=0; cont--)
            {
                Console.Write(cont + ", ");
                Thread.Sleep(8);
            }
            Console.ReadKey();
        }
    }
}
