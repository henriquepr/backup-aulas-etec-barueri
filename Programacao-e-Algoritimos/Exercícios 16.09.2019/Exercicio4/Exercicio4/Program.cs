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
            // EXERCICIO 4
            // ISSO FOI O QUE EU CONSEGUI FAZER, MAS ESTÁ DANDO ERRADO
            int inicio, fim, cont, soma=0;
            Console.Write("Digite o um número inteiro para o ínicio da soma: ");
            inicio = int.Parse(Console.ReadLine());
            Console.Write("Digite o um número inteiro para o fim da soma: ");
            fim = int.Parse(Console.ReadLine());

            while (inicio <= fim)
            {
                cont = inicio;
                inicio++;
                soma = inicio + cont;
            }
            Console.WriteLine(soma);

            Console.ReadKey();
        }
    }
}
