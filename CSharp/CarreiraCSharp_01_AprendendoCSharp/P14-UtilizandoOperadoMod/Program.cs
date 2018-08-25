using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14_UtilizandoOperadoMod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 14 - Utilizando Operador Mod.");

            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            // Simplificando o código acima
            for (int i = 3; i < 100; i += 3)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Execução acabou. Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
