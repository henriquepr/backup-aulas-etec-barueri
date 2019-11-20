using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salario
{
    class Program
    {
        static void Main(string[] args)
        {
            double sal1, sal2, sal3, sal4, sal5, sal6, media, valorretido;
            string nome, cpf;
            Console.WriteLine("Olá! Qual o seu nome?");
            nome = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("Olá senhor {0}! \nDigite seu CPF, por gentileza: ", nome);
            cpf = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("Olá senhor {0}! \nDigite o valor recebido em Janeiro: ", nome);
            sal1 = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Olá senhor {0}! \nDigite o valor recebido em Fevereiro: ", nome);
            sal2 = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Olá senhor {0}! \nDigite o valor recebido em Março: ", nome);
            sal3 = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Olá senhor {0}! \nDigite o valor recebido em Abril: ", nome);
            sal4 = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Olá senhor {0}! \nDigite o valor recebido em Maio: ", nome);
            sal5 = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Olá senhor {0}! \nDigite o valor recebido em Junho: ", nome);
            sal6 = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            media = (sal1+ sal2 + sal3 + sal4+ sal5 + sal6) / 6;

            if (media <= 951.98)
            {
                Console.Write("Isento");
            }
            else
            {
                if (media<=1413.32)
                {
                    valorretido = media*0.075-71.4;
                    Console.WriteLine("Você pagará R$ {0} de Imposto de Renda", valorretido);
                }
                else
                {
                    if (media <= 1875.52)
                    {
                        valorretido = media * 0.15 - 177.40;
                        Console.WriteLine("Você pagará R$ {0} de Imposto de Renda", valorretido);
                    }
                    else
                    {
                        if (media <= 2332.34)
                        {
                            valorretido = media * 0.225 - 318.06;
                            Console.WriteLine("Você pagará R$ {0} de Imposto de Renda", valorretido);
                        }
                        else{
                            valorretido = media * 0.275 - 434.68;
                            Console.WriteLine("Você pagará R$ {0} de Imposto de Renda", valorretido);
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
