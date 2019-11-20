using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_04._09._2019___2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            for(num=0; num<=100; num++/*num++; num=num+1; num+=1*/)
            {
                Console.Write(num +"; ");
            }

            Console.WriteLine("");
            Console.WriteLine("");

            num = 0;
            while (num<=100)
            {
                Console.Write(num + "; ");
                num++;
            }

            Console.ReadKey();
        }
    }
}
