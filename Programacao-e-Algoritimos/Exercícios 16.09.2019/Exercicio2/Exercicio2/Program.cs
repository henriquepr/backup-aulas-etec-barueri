using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 2

            int primos = 2;
            while (primos <= 1000)
            {
                int cont = 2;
                while(cont <= i && i % cont != 0)
                {
                    cont++;
                    if (primos == cont)
                    {
                        Console.Write(primos+ ", ");
                    }
                }
                primos++;
            }

            Console.ReadKey();
        }
    }
}
