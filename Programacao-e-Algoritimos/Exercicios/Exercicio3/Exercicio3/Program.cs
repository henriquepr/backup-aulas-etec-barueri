using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double tempofumando, quantpordia, preco, dinheirogasto;
            Console.WriteLine("Há quantos anos o senhor fuma?");
            tempofumando = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantos maços de cigarro o senhor fuma por dia?");
            quantpordia = double.Parse(Console.ReadLine());
            Console.WriteLine("Quanto, em reais, o senhor paga em um maço de cigarro?");
            preco = double.Parse(Console.ReadLine());
            dinheirogasto = quantpordia*365*tempofumando*preco;

            Console.Write("O senhor gastou um total de R$ "+dinheirogasto+", nesses "+tempofumando+" anos fumando.");

            Console.ReadKey();
        }
    }
}
