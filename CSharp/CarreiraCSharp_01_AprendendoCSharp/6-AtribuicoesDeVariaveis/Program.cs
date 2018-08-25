using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtribuicoesDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando projeto 6 - Atribuicoes de variaveis.");

            int idade = 32;
            int idadeGustavo = idade;

            Console.WriteLine(idade);
            Console.WriteLine(idadeGustavo);

            Console.WriteLine("Execução acabou. Tecle Enter para sair...");
            Console.ReadLine();
        }
    }
}
