using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando o projeto 7 - Condicionais");

            int idadeJoao = 18;
            //int quantidadePessoas = 2;
            //bool acompanhado = quantidadePessoas >= 2;

            bool acompanhado = false;

            //if (idadeJoao >= 18 || acompanhado == true)
            if (idadeJoao >= 18 && acompanhado == true)
            {
                Console.WriteLine("Pode entrar.");
            }
            else
            {
                Console.WriteLine("Não pode entrar.");
            }

            Console.WriteLine("Execução acabou. Tecle enter para sair...");
            Console.ReadLine();

        }
    }
}
