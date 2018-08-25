using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P15_UtilizandoFatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 15 - Utilizando Fatorial");
            /*
             O fatorial de 0 é 1.
             O fatorial de 1 é (0!) * 1 = 1.
             O fatorial de 2 é (1!) * 2 = 2
             O fatorial de 3 é (2!) * 3 = 6
             O fatorial de 4 é (3!) * 4 = 24
             O fatorial de um número n é n * n-1 * n-2 ... até n = 1.
             */

            int fatorial = 1;
            for (int i = 1; i <= 10; i++)
            {
                fatorial *= i;
                Console.WriteLine("Fatorial de " + i + " = " + fatorial);
            }

            Console.WriteLine("Execução acabou. Tecle enter para sair...");
            Console.ReadLine();

        }
    }
}
