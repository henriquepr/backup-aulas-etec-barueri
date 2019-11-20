using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula5
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4, media;
            Console.Write("Digite sua nota do 1ºBim: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.Write("");
            Console.Write("Digite sua nota do 2ºBim: ");
            nota2 = double.Parse(Console.ReadLine());
            Console.Write("");
            Console.Write("Digite sua nota do 3ºBim: ");
            nota3 = double.Parse(Console.ReadLine());
            Console.Write("");
            Console.Write("Digite sua nota do 4ºBim: ");
            nota4 = double.Parse(Console.ReadLine());
            Console.Write("");
            media = (nota1 + nota2 + nota3 + nota4) / 4;
            Console.Clear();
            if (media<2)
            {
                Console.Write("De acordo com a sua nota geral ({0}), você foi reprovado", media);
            }
            else
            {
                if(media<5)
                {
                    Console.Write("De acordo com a sua nota geral ({0}), você está de recuperação", media);
                }
                else
                {
                    if(media<7)
                    {
                        Console.Write("De acordo com a sua nota geral ({0}), você foi aprovado pelo conselho", media);
                    }
                    else
                    {
                        Console.Write("De acordo com a sua nota geral ({0}), você foi aprovado direto", media);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
