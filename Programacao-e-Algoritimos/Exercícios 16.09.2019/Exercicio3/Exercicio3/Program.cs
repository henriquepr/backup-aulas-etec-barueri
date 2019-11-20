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
            string time;
            Console.WriteLine("Olá! Qual o seu time preferido?");
            time = Console.ReadLine();
            switch (time.ToLower())
            {
                case "real madrid":
                case "real madri":
                    Console.Write("\nO Real Madrid é o time com mais Títulos de Mundias (4 no total) e de Champions League (13 no total). O principal jogador do Real Madrid nos últimos anos foi o português Cristiano Ronaldo, que deixou o clube em julho de 2018.");
                    break;
                case "barcelona":
                    Console.Write("\nO Barcelona foi fundado em 1899 por um grupo de futebolistas suíços, ingleses e catalães. O clube se tornou um símbolo da cultura catalã e do nacionalismo catalão. Ao contrário das principais equipes de futebol, os próprios torcedores são quem operam o funcionamento do clube, motivo pelo qual utiliza o lema 'Més que un club' (Mais que um clube). O Barcelona é o segundo clube de futebol mais valioso do mundo, com seu valor estimado em $3.2 bilhões, e o quarto clube de futebol mais rico em termos de receita, com um volume de negócios anual de $150,5 milhões. Seu principal jogador é o Messi (Sinceramente, um gênio)");
                    break;
                case "bayern de munique":
                case "bayern":
                    Console.Write("\nO Bayern de Munique é o principal time da Alemanh, cujo já venceu um total de 29 títulos do campeonato alemão. Esse time tem como principal rival o Borussia Dortmund.");
                    break;
                case "paris saint german":
                case "psg":
                    Console.Write("\nO Paris Saint-Germain Football Club, também conhecido como Paris Saint-Germain ou pela sua sigla 'PSG', é um clube de futebol profissional da França, com sede em Paris. As suas cores são as cores tradicionais da cidade de Paris, o azul e o vermelho, e de Saint-Germain, distrito nos arredores de Paris, branco. Seu principal jogador é o brasileiro Neymar.");
                    break;
                case "juventus":
                    Console.Write("\nJuventus Football Club (em latim: iuventude, pronunciado: juˈvɛntus), é um clube de futebol italiano, também conhecida como Juventus de Turim, Juve ou ainda A Velha Senhora (em Italiano La Vecchia Signora). A Juve é a maior detentora de scudettos do futebol Italiano com 35 títulos internos e é também o clube italiano com mais títulos oficiais se somados os títulos nacionais, internacionais e continentes (68 no total). É um dos clubes mais tradicionais e relevantes do mundo, tal qual conquistou todos os títulos do seu continente, feito alcançado por poucos clubes.");
                    break;
                default:
                    Console. WriteLine("Lamentamos mas você escolheu um time que não consta em nosso sistema...");
                    break;
            }

            Console.ReadKey();
        }
    }
}
