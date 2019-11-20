using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_04._09._2019___Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont;
            for(cont = 0; cont < 1001; cont++){
                if (cont % 3 == 0 && cont % 5 == 0){
                    Console.Write(cont + " ");
                }
            }

            /*int inicio=1, final=1000;

            while (inicio <= final)
            {
                if (inicio % 3==0 && inicio % 5 ==0)
                {
                    Console.Write(inicio + " ");
                }
                inicio++;
            }*/

            Console.ReadKey();
        }
    }
}
